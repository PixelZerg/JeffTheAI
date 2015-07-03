using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffEmotion
{
    class Program
    {
        /*
+----------+---+----------+------------+-------------+
|          | 0 |    1     |     2      |      3      |
+----------+---+----------+------------+-------------+
| SAD      | - | down     | miserable  | emo         |
| Peaceful | - | calm     | thoughtful | Relaxed     |
| Joyful   | - | happy    | excited    | wooo        |
| Scared   | - | hesitant | anxious    | embarrassed |
| mad      | - | hurt     | angry      | furious     |
+----------+---+----------+------------+-------------+
         */
        public static int Sad = 0;
        public static int Peace = 0;
        public static int Joy = 0;
        public static int Scare = 0;
        public static int Mad = 0;

        public static int sensitivity = 5;

        /*
        public static readonly string[] parseSad = { "-", "down", "miserable", "emo" };
        public static readonly string[] parsePeace = { "-", "calm", "thoughtful", "Relaxed" };
        public static readonly string[] parseJoy = { "-", "happy", "excited", "wooo" };
        public static readonly string[] parseScare = { "-", "hesitant", "anxious", "embarrassed" };
        public static readonly string[] parseMad = { "-", "hurt", "angry", "furious" };
         */

        static void Main(string[] args)
        {
            /* What I want output to look like:
             < Sad - 0 (Down) | Peaceful - 0 (calm) | Joyful - 0 (woo) | Scared - 0 (hesitant)| Mad - 0 (---) >
             */
            #region Log
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("<");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Sad - " + Sad + " (" + parseEmotion("Sad") + ") " );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( "Peaceful - " + Peace + " (" + parseEmotion("Peace") + ") " );
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write( "Joy - " + Joy + " (" + parseEmotion("Joy") + ") " );
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(  "Scare - " + Scare + " (" + parseEmotion("Scare") + ") " );
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Mad - " + Mad + " (" + parseEmotion("Mad") + ") ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(">" + Environment.NewLine);
            #endregion
                Console.ReadKey();
                Sad++;
                Peace++;
                Joy++;
                Scare++;
                Mad++;
            Main(new string[1] {"ooloo"});

            //todo for nexttime: MAKE emotion cardinal
            // also make antagonistic pairs of emotions work together : 
            //IE make a method to add/decrease points which will directly affect opposite's values accordingly...
        }

        public static void InsultCheck(string txt)
        {
            string[] stxt = txt.Split(' ');
            int insults = 0;

            foreach (var item in stxt)
            {
                
            }
        }
        public static string parseEmotion(string emotion)
        {
            if (emotion.ToLower().Contains("sad") == true)
            {
                if (Sad >= sensitivity)
                {
                    if (Sad >= sensitivity * 2)
                    {
                        if (Sad >= sensitivity * 3)
                        {
                            return "emo";
                        }
                        else return "miserable";
                    }
                    else return "down";
                }
                else return "---";
            } else

            if (emotion.ToLower().Contains("peace") == true)
            {
                if (Peace >= sensitivity)
                {
                    if (Peace >= sensitivity * 2)
                    {
                        if (Peace >= sensitivity * 3)
                        {
                            return "relaxed";
                        }
                        else return "thoughtful";
                    }
                    else return "calm";
                }
                else return "---";
            } else

            if (emotion.ToLower().Contains("joy") == true)
            {
                if (Joy >= sensitivity)
                {
                    if (Joy >= sensitivity * 2)
                    {
                        if (Joy >= sensitivity * 3)
                        {
                            return "woo";
                        }
                        else return "excited";
                    }
                    else return "happy";
                }
                else return "---";
            }
            else
            if (emotion.ToLower().Contains("scare") == true)
            {
                if (Scare >= sensitivity)
                {
                    if (Scare >= sensitivity * 2)
                    {
                        if (Scare >= sensitivity * 3)
                        {
                            return "embarrassed";
                        }
                        else return "anxious";
                    }
                    else return "hesitant";
                }
                else return "---";
            }
            else
                if (emotion.ToLower().Contains("mad") == true)
                {
                    if (Mad >= sensitivity)
                    {
                        if (Mad >= sensitivity * 2)
                        {
                            if (Mad >= sensitivity * 3)
                            {
                                return "furious";
                            }
                            else return "angry";
                        }
                        else return "hurt";
                    }
                    else return "---";
                }

                else
                {
                    return "NaN";
                    //wtf exception:
                    //exep(69);
                }

        }
    }
}
