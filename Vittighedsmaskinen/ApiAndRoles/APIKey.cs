using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DAL;

namespace Vittighedsmaskinen.ApiAndRoles
{
    public class APIKey
    {
        public string Key { get; set; }
        public Role ApiRole { get; set; }

        public APIKey(string key, Role apirole)
        {
            this.Key = key;
            this.ApiRole = apirole;
        }
    }
}
