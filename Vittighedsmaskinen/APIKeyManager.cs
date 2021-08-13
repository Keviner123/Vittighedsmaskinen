using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.ApiAndRoles;
using Vittighedsmaskinen.DAL;

namespace Vittighedsmaskinen
{
    public class APIKeyManager
    {
        public Role GetRolesByAPIKey(string QueryAPIKey)
        {
            DALApikeys APIKeys = new DALApikeys();

            //Check if the role exists
            foreach (APIKey i in APIKeys.APIKeys)
            {
                if (i.Key == QueryAPIKey)
                {
                    return (i.ApiRole);
                }
            }

            return (null);
        }
    }
}
