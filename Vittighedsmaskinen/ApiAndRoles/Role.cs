using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen.ApiAndRoles
{
    public class Role
    {
        public string Name { get; set; }
        public List<Categories.Category> AllowedCategories { get; set; }

        public Role(string name, List<Categories.Category> allowedcategories) {

            this.Name = name;
            this.AllowedCategories = allowedcategories;
        }
    }
}
