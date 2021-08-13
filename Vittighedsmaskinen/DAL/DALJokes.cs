using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class DALJokes
    {
        public List<Joke> List { get; set; }

        public DALJokes()
        {
            List<Joke> Jokes = new List<Joke>();
            Jokes.Add(new Joke(1, Vittighedsmaskinen.Categories.Category.Dad, "Hvorfor har Gordon Ramsey så meget kakao stående i sit køleskab?", "Han er kok-jo ", Languages.Language.da));
            Jokes.Add(new Joke(2, Vittighedsmaskinen.Categories.Category.Dad, "Hvad kalder man nationalretten i Grækenland?", "Zeus og kartofler.", Languages.Language.da));
            Jokes.Add(new Joke(3, Vittighedsmaskinen.Categories.Category.Dad, "Hvilket dyr elsker at samle flasker?", "Panteren", Languages.Language.da));
            Jokes.Add(new Joke(4, Vittighedsmaskinen.Categories.Category.Dad, "Ved du hvordan man bliver klogere på tordenvejr?", "Man tager et lynkursus", Languages.Language.da));
            Jokes.Add(new Joke(5, Vittighedsmaskinen.Categories.Category.Dad, "Hvad bestiller fåret altid hos den lokale pølsemand?", "En mæææh det hele", Languages.Language.da));
            Jokes.Add(new Joke(6, Vittighedsmaskinen.Categories.Category.Dad, "Hvad gør spiderman efter han har drukket sin kaffe?", "Han ædder-koppen", Languages.Language.da));
            Jokes.Add(new Joke(7, Vittighedsmaskinen.Categories.Category.Dad, "Hvorfor ligger den ordblinde hval på havets bund og griner?", "Fordi den har læst at den er verdens største pjattedyr.", Languages.Language.da));
            Jokes.Add(new Joke(8, Vittighedsmaskinen.Categories.Category.Dad, "Hvad er det der ligger på bunden af en spand og siger dav dav?", "En spandauer", Languages.Language.da));

            Jokes.Add(new Joke(9, Vittighedsmaskinen.Categories.Category.Dad, "I'm afraid for the calendar. Its days are numbered.", Languages.Language.en));
            Jokes.Add(new Joke(10, Vittighedsmaskinen.Categories.Category.Dad, "My wife said I should do lunges to stay in shape. That would be a big step forward.", Languages.Language.en));
            Jokes.Add(new Joke(11, Vittighedsmaskinen.Categories.Category.Dad, "Why do fathers take an extra pair of socks when they go golfing?", "In case they get a hole in one!", Languages.Language.en));
            Jokes.Add(new Joke(12, Vittighedsmaskinen.Categories.Category.Dad, "Singing in the shower is fun until you get soap in your mouth. Then it's a soap opera.", Languages.Language.en));
            Jokes.Add(new Joke(13, Vittighedsmaskinen.Categories.Category.Dad, "What do a tick and the Eiffel Tower have in common?", "They're both Paris sites.", Languages.Language.en));
            Jokes.Add(new Joke(14, Vittighedsmaskinen.Categories.Category.Dad, "What do you call a fish wearing a bowtie?", "Sofishticated", Languages.Language.en));
            Jokes.Add(new Joke(15, Vittighedsmaskinen.Categories.Category.Dad, "How do you follow Will Smith in the snow?", "You follow the fresh prints.", Languages.Language.en));
            Jokes.Add(new Joke(16, Vittighedsmaskinen.Categories.Category.Dad, "I thought the dryer was shrinking my clothes. Turns out it was the refrigerator all along.", Languages.Language.en));

            Jokes.Add(new Joke(17, Vittighedsmaskinen.Categories.Category.Blond, "Why can't a blonde dial 911?", "She can't find the eleven.", Languages.Language.en));
            Jokes.Add(new Joke(18, Vittighedsmaskinen.Categories.Category.Blond, "What did the blonde say when she saw the Cheerios box?", "Omg, donut seeds!", Languages.Language.en));
            Jokes.Add(new Joke(19, Vittighedsmaskinen.Categories.Category.Blond, "Why did the blonde tip toe near the medicine cabinet?", "Because she didn't want to wake the sleeping pills!!", Languages.Language.en));
            Jokes.Add(new Joke(20, Vittighedsmaskinen.Categories.Category.Blond, "Three blondes walk into a building. You'd think one of them would've seen it.....", Languages.Language.en));
            Jokes.Add(new Joke(21, Vittighedsmaskinen.Categories.Category.Blond, "Why did the blonde put her iPad in a blender?", "Because she wanted to make apple juice.", Languages.Language.en));
            Jokes.Add(new Joke(22, Vittighedsmaskinen.Categories.Category.Blond, "How do you confuse a blonde?", "Put her in a circle and tell her to go to the corner.", Languages.Language.en));
            Jokes.Add(new Joke(23, Vittighedsmaskinen.Categories.Category.Blond, "How did the blonde try to kill the bird??", "She threw it off a cliff.", Languages.Language.en));
            Jokes.Add(new Joke(24, Vittighedsmaskinen.Categories.Category.Blond, "How did the blonde die drinking milk?", "The cow fell on her.", Languages.Language.en));

            Jokes.Add(new Joke(25, Vittighedsmaskinen.Categories.Category.Blond, "Hvad Kalder man en blondine med en hjerne?", "Uddød", Languages.Language.da));
            Jokes.Add(new Joke(26, Vittighedsmaskinen.Categories.Category.Blond, "17 blondiner stod uden for en bar. En mand kom forbi og spurgte hvorfor de ikke gik ind, hvorefter blondinerne svare", "fordi vi har hørt at man skal være 18 for at komme ind.", Languages.Language.da));
            Jokes.Add(new Joke(27, Vittighedsmaskinen.Categories.Category.Blond, "Hvad er forskellen på en myg og en blondine?", "Myggen stopper med at suge når man klapper den.", Languages.Language.da));
            Jokes.Add(new Joke(28, Vittighedsmaskinen.Categories.Category.Blond, "Hvorfor har blondiner stiger med ude at købe ind?", "Fordi priserne er så høje!", Languages.Language.da));
            Jokes.Add(new Joke(29, Vittighedsmaskinen.Categories.Category.Blond, "hvad går og går men kommer ingen vejne?", "en blondine i en svingdør.", Languages.Language.da));
            Jokes.Add(new Joke(30, Vittighedsmaskinen.Categories.Category.Blond, "Hvad kalder du en intelligent blondine?", "En Golden Retriever.", Languages.Language.da));
            Jokes.Add(new Joke(31, Vittighedsmaskinen.Categories.Category.Blond, "Hvorfor tar blondiner døren af når de skal på toilet?", "så man ikke kan kigge igennem nøglehullet", Languages.Language.da));
            Jokes.Add(new Joke(32, Vittighedsmaskinen.Categories.Category.Blond, "Den ene blondine spørg den anden, blondine om hvad der ligger længst væk, London eller månen. Den anden blondine svarer, er du dum eller hvad, kan du måske se London her fra?", Languages.Language.da));

            Jokes.Add(new Joke(33, Vittighedsmaskinen.Categories.Category.General, "You know it is going to be a bad day when the letters in your alphabet soup spell D-I-S-A-S-T-E-R.", Languages.Language.en));
            Jokes.Add(new Joke(34, Vittighedsmaskinen.Categories.Category.General, "A fire hydrant has H-2-O on the inside and K-9-P on the outside.", Languages.Language.en));
            Jokes.Add(new Joke(35, Vittighedsmaskinen.Categories.Category.General, "Did you hear about the crook who stole a calendar? He got twelve months.", Languages.Language.en));
            Jokes.Add(new Joke(36, Vittighedsmaskinen.Categories.Category.General, "Did you hear about the semi-colon that broke the law? He was given two consecutive sentences.", Languages.Language.en));
            Jokes.Add(new Joke(37, Vittighedsmaskinen.Categories.Category.General, "I own the world's worst thesaurus. Not only is it awful, it's awful.", Languages.Language.en));
            Jokes.Add(new Joke(38, Vittighedsmaskinen.Categories.Category.General, "What's the difference between a good joke and a bad joke timing.", Languages.Language.en));
            Jokes.Add(new Joke(39, Vittighedsmaskinen.Categories.Category.General, "Velcro—what a rip-off!", Languages.Language.en));
            Jokes.Add(new Joke(40, Vittighedsmaskinen.Categories.Category.General, "I've just written a song about tortillas; actually, it’s more of a rap.", Languages.Language.en));

            Jokes.Add(new Joke(41, Vittighedsmaskinen.Categories.Category.General, "Alle børnene kom sikkert over havet undtagen Jannik han tog titanic", Languages.Language.da));
            Jokes.Add(new Joke(42, Vittighedsmaskinen.Categories.Category.General, "Jeg overvejer at gifte mig med en tysker er det over grænsen?", Languages.Language.da));
            Jokes.Add(new Joke(43, Vittighedsmaskinen.Categories.Category.General, "Hvad kalder man en indbagt haj", "haj med dej", Languages.Language.da));
            Jokes.Add(new Joke(44, Vittighedsmaskinen.Categories.Category.General, "hvad er ligheden mellem en kvinde og en mobiltelefon?", "når man lige har lært dem at kende kommer der en ny og bedre model.", Languages.Language.da));
            Jokes.Add(new Joke(45, Vittighedsmaskinen.Categories.Category.General, "Hvorfor hyler prærieulve kun om natten?", "De kan kun se kaktusserne om dagen!.", Languages.Language.da));
            Jokes.Add(new Joke(46, Vittighedsmaskinen.Categories.Category.General, "Alle børnene gik ind i helikopteren, undtagen Ellen, hun gik ind i propellen!!", Languages.Language.da));
            Jokes.Add(new Joke(47, Vittighedsmaskinen.Categories.Category.General, "Alle børnene gik over broen untagen Kaj han faldte ned og blev ædt af en haj", Languages.Language.da));
            Jokes.Add(new Joke(48, Vittighedsmaskinen.Categories.Category.General, "Hvorfor græder tæppet?", "fordi det er blevet banket", Languages.Language.da));

            List = Jokes;
        }
    }
}
