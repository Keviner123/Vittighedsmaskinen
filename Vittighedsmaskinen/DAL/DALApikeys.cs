using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.ApiAndRoles;

namespace Vittighedsmaskinen.DAL
{
    public class DALApikeys
    {
        public List<APIKey> APIKeys = new List<APIKey>();

        public DALApikeys()
        {
            DALRoles Roles = new DALRoles();
            APIKeys.Add(new APIKey("a0073ed7-8309-416b-8177-08f7b50b837a", Roles.GeneralUser));
            APIKeys.Add(new APIKey("15610bb3-050d-4d6e-b730-955df0eab0b2", Roles.SuperUser));
            APIKeys.Add(new APIKey("c1236220-a4d6-477c-9739-bd2cf34e7ffe", Roles.DadUser));

        }
    }
}
