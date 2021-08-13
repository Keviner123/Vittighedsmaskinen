using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class JokeManager
    {
        Random r = new Random();

        public List<Joke> FilterJokesByLanguage(List<Joke> UnfilteredJokes, Languages.Language PreferredLanguage)
        {
            List<Joke> FilteredJokes = new List<Joke>();

            for (int i = 0; i < UnfilteredJokes.Count; i++)
            {
                if(UnfilteredJokes[i].Language == PreferredLanguage)
                {
                    FilteredJokes.Add(UnfilteredJokes[i]);
                }
            }

            return (FilteredJokes);
        }

        public Joke GetRandomJoke(List<int> ReadJokes, int PreferredCategory, Languages.Language PreferredLanguage)
        {
            DALJokes Jokes = new DALJokes();

            List<Joke> JokesInPreferredCategory = new List<Joke>();


            for (int j = 0; j < Jokes.List.Count; j++)
            {
                if (Jokes.List[j].Category == ((Categories.Category)PreferredCategory))
                {
                    JokesInPreferredCategory.Add(Jokes.List[j]);
                }
            }

            //Remove already displayed jokes
            for (int i = 0; i < ReadJokes.Count; i++)
            {
                for (int j = 0; j < JokesInPreferredCategory.Count; j++)
                {
                    if (JokesInPreferredCategory[j].Id == ReadJokes[i])
                    {
                        JokesInPreferredCategory.RemoveAt(j);
                    }
                }
            }

            JokesInPreferredCategory = FilterJokesByLanguage(JokesInPreferredCategory, PreferredLanguage);

            //Check if there are more jokes left
            if (JokesInPreferredCategory.Count != 0)
            {
                int index = r.Next(JokesInPreferredCategory.Count);
                return JokesInPreferredCategory[index];
            }
            else
            {
                return (null);
            }
        }
    }
}
