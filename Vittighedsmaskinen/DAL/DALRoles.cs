using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.ApiAndRoles;

namespace Vittighedsmaskinen.DAL
{
    public class DALRoles
    {
        public Role GeneralUser = new Role("GeneralUser ", new List<Categories.Category> { Categories.Category.General });
        public Role SuperUser = new Role("SuperUser ", new List<Categories.Category> { Categories.Category.General, Categories.Category.Blond, Categories.Category.Dad });
        public Role DadUser = new Role("Dad ", new List<Categories.Category> { Categories.Category.Dad });

    }
}
