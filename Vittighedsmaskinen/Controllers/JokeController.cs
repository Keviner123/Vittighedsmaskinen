using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vittighedsmaskinen.ApiAndRoles;
using Vittighedsmaskinen.DAL;

namespace Vittighedsmaskinen.Controllers
{
    [ApiController]
    [Route("api/GetRandomJoke")]
    public class GetJoke : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {

            APIKeyManager APIKeyMgmt = new APIKeyManager();
            Role Userroles;

           
            Userroles = APIKeyMgmt.GetRolesByAPIKey(Request.Headers["x-api-key"]);
            
            //Check if the user has submitted a valid API key
            if(Userroles == null)
            {
                return ("Invalid API key");
            }

            string PreferredCategoryId = Request.Cookies["PreferredCategoryId"];
            //Check if the user has set a preferred category
            if (PreferredCategoryId == null)
            {
                return ("No preferred Category has been set, use the endpoint SetPreferredCategoryId");
            }

            //Check if the users PreferredCategoryId is allowed for the role
            bool CategoryAllowed = false;
            for (int i = 0; i < Userroles.AllowedCategories.Count; i++)
            {
                if(Userroles.AllowedCategories[i] == ((Categories.Category)Int32.Parse(PreferredCategoryId)))
                {
                    CategoryAllowed = true;
                }
            }

            if (!CategoryAllowed)
            {
                return ("You are unauthorized to access this resource");
            }


            DALJokes Jokes = new DALJokes();
            List<int> ReadJokes;
            JokeManager JM = new JokeManager();
            string UserReadJokes = HttpContext.Session.GetString("ReadJokes");
            Languages.Language PreferredLanguage;


            //Check if the user has sent a valid language, otherwise use the default one.
            try
            {
                PreferredLanguage = (Languages.Language)Enum.Parse(typeof(Languages.Language), Request.Headers["Content-Language"]);
            }
            catch (Exception)
            {
                PreferredLanguage = Languages.Language.en;
            }



            //Check if the user has a list of read jokes, if not add an empty one
            if (UserReadJokes == null)
            {
                ReadJokes = new List<int>();
            }
            else
            {
                ReadJokes = JsonConvert.DeserializeObject<List<int>>(UserReadJokes);
            }

            //Get a joke for the user based on his/her preferences
            Joke RandomJoke = JM.GetRandomJoke(ReadJokes, Int32.Parse(PreferredCategoryId), PreferredLanguage);


            //Check if there was an available joke.
            if(RandomJoke != null)
            {

                //Set that the joke has been read
                ReadJokes.Add(RandomJoke.Id);
                HttpContext.Session.SetString("ReadJokes", JsonConvert.SerializeObject(ReadJokes));

                //Return the joke in JSON format so another application can use it
                return (JsonConvert.SerializeObject(RandomJoke));
            }
            else
            {
                return ("No more jokes in current category. \nchange category to get more jokes");
            }
        }

    }

    [Route("api/SetPreferredCategoryId")]
    public class SetPreferredCategory : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get(int CategoryId)
        {
            Categories.Category PreferredCategoryId = (Categories.Category)CategoryId;

            //Check if the users favorite category id is valid.
            if (PreferredCategoryId.ToString().Length == 1){
                return ("Unknown Category Id");
            }
            else
            {
                Response.Cookies.Append("PreferredCategoryId", CategoryId.ToString());
            }

            return ("Favorite category set") ;
        }
    }
}
