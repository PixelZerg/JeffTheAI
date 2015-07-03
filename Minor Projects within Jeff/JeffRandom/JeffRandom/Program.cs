using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace JeffRandom
{
    class Program
    {
        public static bool wait = true;
        static void Main(string[] args)
        {
            defs();
        }

        public static void pause(int time)
        {if (wait == true){TimeSpan timeout=TimeSpan.FromMilliseconds(time);
         DateTime start_time=DateTime.Now;
         while(DateTime.Now-start_time<timeout){}}}

        public static void defs()
        {
            ChangeSubject();
        }

        public static void ChangeSubject()
        {
            Console.Write("Intresting... however this leads me to wonder... ");
            string wh7 = "Wh7NaN";
            string art = "artNaN";
            string nom = "nomNaN";
            string stat = "statNaN";
            Random rnd = new Random();
            bool plural = false;

            /* stuff to define: *
             * does/do          *
             * is/are           */

            int six = rnd.Next(0, 7);
            int tmprnd = 0;
            if (six == 1){wh7 = "who";}
            if (six == 2) { wh7 = "what";}
            if (six == 3){wh7 = "when";}
            if (six == 4){wh7 = "where";}
            if (six == 5){wh7 = "why";}
            if (six == 6){wh7 = "how";}
            if (six > 6 || six < 1){wh7 = "why";}

            pause(300);
            Console.Write(wh7);

            string[] sngNoms = new string[] { "my twin", "HonkHonk the kitten", "Mooman", "George the Man Eating Cactus", "Mr.Octopi the trycerratopps", "the Venus Fly Trap", "my moustache" };
            string[] plNoms = new string[] { "sailors", "all my pet potatos", "my imaginary friends", "my rocks", "yesterday's leftovers" };
            tmprnd = rnd.Next(0, 3);
            if (tmprnd == 1)
            {
                tmprnd = rnd.Next(0, plNoms.Length);
                plural = true;
                int nana = tmprnd - 0;
                nom = plNoms[nana];
            }
            else
            {
                tmprnd = rnd.Next(0, sngNoms.Length);
                plural = false;
                int nana = tmprnd - 0;
                nom = sngNoms[nana];
            }

            tmprnd = rnd.Next(0, 3);
            if (tmprnd == 1) { if (plural == true) { art = "are"; } else { art = "is"; } }
            else { if (plural == true) { art = "do"; } else { art = "does"; } }

            pause(300);
            Console.Write(" " + art + " " );
            pause(300);
            Console.Write(Environment.NewLine + nom);

            string[] statWhyDoes = new string[2] { " have such amazing hair?!", " look so constipated?" };
            string[] statWhoDoes = new string[2] { " like to have dinner with?", " enjoy dancing with?" };
            string[] statWhatDoes = new string[2] { " do with all that free-time?", " like doing behind open doors?" };
            string[] statWhenDoes = new string[2] { " finish eating all those lemons?", " start barking vigourously?" };
            string[] statWhereDoes = new string[2] { " keep dissapearing off to?", " shed the sheds?" };
            string[] statHowDoes = new string[2] { " loose weight so easily?!!?", " eat so many bananas in such little a time?" };

            string[] statWhoIs = new string[2] { "'s best friend?", "'s most famous friend?" };
            string[] statWhatIs = new string[2] { "'s strange expression supposed to signify?", " wearing on this fine day? I don't have my glasses so I can't see >.<" };
            string[] statWhenIs = new string[2] { "'s birthday?", " finally going to learn this?!" };
            string[] statWhereIs = new string[2] { "'s car?", "'s home? Heuhehuehuheuhuehhhehehe..." };
            string[] statWhyIs = new string[2] { " so depressed today?", " so hyper today?" };
            string[] statHowIs = new string[2] { " doing today? I wonder...", " diet commming along?" };

            //todo for tommorow:
            /* actually form the sentence */
            //decide how is/does
            tmprnd = rnd.Next(0, statWhoIs.Length);
           // tmprnd = tmprnd - 1;
            if (art == "is" || art == "are")
            {
                if (wh7 == "who") { stat = statWhoIs[tmprnd]; }
                if (wh7 == "what") { stat = statWhatIs[tmprnd]; }
                if (wh7 == "when") { stat = statWhenIs[tmprnd]; }
                if (wh7 == "where") { stat = statWhereIs[tmprnd]; }
                if (wh7 == "why") { stat = statWhyIs[tmprnd]; }
                if (wh7 == "how") { stat = statHowIs[tmprnd]; }
            }
            else if (art == "does" || art == "do")
            {
                if (wh7 == "who") { stat = statWhoDoes[tmprnd]; }
                if (wh7 == "what") { stat = statWhatDoes[tmprnd]; }
                if (wh7 == "when") { stat = statWhenDoes[tmprnd]; }
                if (wh7 == "where") { stat = statWhereDoes[tmprnd]; }
                if (wh7 == "why") { stat = statWhyDoes[tmprnd]; }
                if (wh7 == "how") { stat = statHowDoes[tmprnd]; }
            }
            pause(300);
            Console.WriteLine(stat);
            var tmp = Console.ReadLine();
            if (tmp == "wait = false"){wait = false;}
            if(tmp == "wait = true"){wait = true;}
            Console.Clear();
            defs();
        }
    }
}
