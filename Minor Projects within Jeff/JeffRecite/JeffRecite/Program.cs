using System;
using System.IO;
using System.Linq;

namespace JeffRecite
{
    class Program
    {
        //variable dependencies:
        public static bool wait = false;
        public static string wotsay;

        static void Main(string[] args)
        {
            wotsay = Console.ReadLine();
            recite();
        }

        public static void recite()
        {
            string[] locq = new string[100];
            string[] locsay = new string[100];
            int lalala = 0;
            Console.ForegroundColor = ConsoleColor.White;
            /*
             * 
            Console.WriteLine("I don't know what to say to that so I'm going to blurt out ");
            Console.WriteLine("some random text by means of apology");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("v");
             */
            var qmax = File.ReadAllLines("q").Length;
            int line = 1;
            while (line != qmax)
            {
                int readline = line - 0;
                string qraw = File.ReadLines("q").Skip(readline).Take(1).First();
                // Console.WriteLine("Reading line " + line + " of " + qmax);

                string[] q = qraw.Split('`');
                int args = q.Count();
                foreach (var item in q)
                {
                    Console.Write(item);
                    int no = 0;
                    if (wotsay.ToLower().Contains(item.ToLower()) == true)
                    {
                        //store in q
                        q[no] = item;
                        no++;
                        //deal with it B-)
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("^");
                        Console.ForegroundColor = ConsoleColor.White;
                        pause(100);

                    }
                    else
                    {
                        lalala++;
                        Console.Write(Environment.NewLine);
                        if (lalala > qmax)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" I am checking...");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            pause(30);
                            Console.Clear();
                        }
                    }

                    //look in next one
                    int saymax = File.ReadAllLines("say").Length;
                    int linee = 0;
                    while (linee != saymax)
                    {
                        int readlinee = line - 0;
                        string sayraw = File.ReadLines("say").Skip(readline).Take(1).First();
                        // Console.WriteLine("Reading line " + line + " of " + qmax);

                        string[] say = sayraw.Split('`');
                        int sayargs = say.Count();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" --> " + sayraw);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        //actual bit
                        pause(700);
                        Console.Clear();
                        Random rnd = new Random();
                        int rand = rnd.Next(say.Length);
                        fin(say[rand]);
                        defs();
                    }
                    linee++;
                }
                line++;
            }
            //special replies mrk2
            if (wotsay.Contains("?") == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What a strange question - I think that ");
            }
            if (wotsay.ToLower().Contains("joke") == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You want a joke? This request ... I think that ");
            }
            //CHANGE SUBJECT
            ChangeSubject();
        }

        //dependecies:
        public static void pause(int time)
        {
            if (wait == true)
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(time);
                DateTime start_time = DateTime.Now;
                while (DateTime.Now - start_time < timeout) { }
            }
        }
        public static void defs()
        {
            Console.WriteLine("Defs");
        }
        public static void ChangeSubject()
        {
            Console.WriteLine("ChangeSubject");
        }
        public static void fin(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
