using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class Joke
    {
        public int Id { get; set; }
        public Categories.Category Category { get; set; }
        public string Description { get; set; }
        public string Punchline { get; set; }
        public Languages.Language Language { get; set; }


        public Joke(int id, Categories.Category category, string description, string punchline, Languages.Language language)
        {
            this.Id = id;
            this.Category = category;
            this.Description = description;
            this.Punchline = punchline;
            this.Language = language;
        }

        public Joke(int id, Categories.Category category, string description, Languages.Language language)
        {
            this.Id = id;
            this.Category = category;
            this.Description = description;
            this.Language = language;
        }
    }
}
