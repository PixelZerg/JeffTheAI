using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synonyms
{
    class Program
    {
        public static bool ga;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter some text and i'll rephrase it");
            var wotsay = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            linew('#');
            Console.ForegroundColor = ConsoleColor.White;
            synonyms(wotsay);
            Console.ForegroundColor = ConsoleColor.White;
            linew('~');
            Console.WriteLine(shuffle(synonyms(wotsay)));
            Console.ForegroundColor = ConsoleColor.White;
            linew('~');
            Main(
                new string[] { "aaa", "naa" });
        }

        public static string synonyms(string txt)
        {
            #region thesaurus jagarray

            string[][] jagarray = new string[4][];

            jagarray[0] = new string[] { "nice", "excellent", "awesome", "outstanding", "great", "good", "exceptional", "positive", "marvelous", "ace" };
            jagarray[1] = new string[] { "bad", "terrible", "horrible", "poor", "aweful", "dreadful", "unacceptable" };
            jagarray[2] = new string[] { "incredibly", "outstandingly", "extremely", "very", "genuinely", "immensely", "greatly", "notably" };
            jagarray[3] = new string[] { "in fact", "to be fact", "to be frank" };

            #endregion

            //split up the sentence
            string[] stxt = txt.Split(' ');

            int num = 0;
            foreach (string str in stxt)
            {
                ga = false;
                foreach (string[] astring in jagarray)
                {
                    foreach (string jagstr in astring)
                    {
                        if (str.ToLower().Contains(jagstr) == true)
                        {
                            ga = true;
                            #region replace
                            var rand = new Random();
                            int rnd = rand.Next(astring.Length);
                            stxt[num] = astring[rnd];
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(stxt[num] + " ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            #endregion
                        }
                        else { /*Console.Write(str.ToLower());*/ }
                    }
                } num++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (ga == false)
                {
                    Console.Write(str + " ");
                }
            } Console.Write(Environment
                .NewLine);

            //stitch the sentence back together again
            string final = string.Join(" ", stxt);
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(final);
            return final;

        }
        public static string shuffle(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] stxt = txt.ToLower().Split(' ');
            string[] stxtp = new string[stxt.Length + 1];
            string[] stxtpm = new string[stxt.Length + 1];
            //question
            int no = 0;
            foreach (var item in stxt)
            {
                stxtp[no + 1] = stxt[no];
                no++;
            }
            int ni = 0;
            foreach (var item in stxtp)
            {
                if(item == "is" ||item == "are")
                {
                    stxtp[ni] = null;
                    //move all strings after ni up
                    int nio = 0;
                    foreach (var iti in stxtp)
                    {
                        if (nio > ni)
                        {
                            stxtpm[nio-1] = stxtp[nio];
                        }
                        else
                        {
                            stxtpm[nio] = stxtp[nio];
                        }
                            nio++;
                    }
                    //capitalise first letter!!
                    var firstltr = item[0].ToString().ToUpper();
                    int niue = 0;
                    string[] firstword = new string[item.Length];
                    foreach (var ie in item)
                    {
                        if(niue != 0){
                            firstword[niue -1] = item[niue].ToString();
                        }
                        niue++;
                    }
                    stxtpm[0] = firstltr + string.Join("", firstword);
                }
                ni++;
            }
            //log
            //foreach (var item in stxtp) { Console.Write(item + " "); } Console.Write("?" + Environment.NewLine);
            var final = string.Join(" ", stxtpm) + "?";
            //Console.WriteLine(final);
            return final;
        }
        public static void linew(char symbol)
        {
            int tmp = Console.WindowWidth;
            while (tmp != 0)
            {
                Console.Write(symbol.ToString());
                tmp--;
            }
        }
    }
}
