using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace jeff_Framework
{
    public class Class1
    {
        public static string[] q = new string [0];
        public static string[] say = new string[0];
        public static string MainClass = "Class1";
        public static string MainMethod = "fatal_exep";
        public static string wotsay = "null";

        static void caller(String myclass, String mymethod)
        {
            // Get a type from the string 
            Type type = Type.GetType(myclass);
            // Create an instance of that type
            Object obj = Activator.CreateInstance(type);
            // Retrieve the method you are looking for
            MethodInfo methodInfo = type.GetMethod(mymethod);
            // Invoke the method on the instance we created above
            methodInfo.Invoke(obj, null);
        }

        public static void fatal_exep()
        {
            //fatal exeption so exit without further notice:
            Console.WriteLine("Scripting Error 001: Failed to define jeff-framework.MainMethod/jeff-framework.MainClass or both - Application will now exit :'(");
            Environment.Exit(1);
        }
        public static void exep(int no)
        {
            //Console.WriteLine("EXCEPTION");
            //check
            if (no == 69) { Console.WriteLine("A WTF exception has occured! Application will now exit"); Environment.Exit(1); }
            if (no == 1) { recite(); } //this is a 'dunno what to say' exeption so see if .jeff files have anything
        }
        public static void recite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I don't know what to say to that so I'm going to blurt out ");
            Console.WriteLine("some random text by means of apology");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("v");
            int n = 0;
            foreach (var item in q)
            {
                if (wotsay.Contains(item) == true)
                {
                    //wooo yay we're saved!
                    Console.Clear(); // I take that back
                    Console.WriteLine(say[n]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    caller(MainClass, MainMethod);
                }
                else
                {
                    n++;
                }
            }
        }
        public static void scan()
        {
            Console.WriteLine("Scanning .jeff files:");
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("q");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(counter.ToString() + " | " + line);
                counter++;
            } file.Close();
            int counteru = 0;
            Console.WriteLine(" ");
            System.IO.StreamReader fil = new System.IO.StreamReader("say");
            while ((line = fil.ReadLine()) != null)
            {
                // Console.WriteLine(counteru.ToString() + " | " + line);
                counteru++;
            } fil.Close();
            if (counter > counteru || counter < counteru)
            {
                Console.WriteLine("Invalid .jeff files! Cannot load");
                Environment.Exit(1);
            }
            //else continue forth to store vars:
            Console.WriteLine(".jeff files found!");
            Console.WriteLine("no. args = " + counteru);

            say = new string[counteru + 1];
            q = new string[counter + 1];

            counter = 0;
            System.IO.StreamReader fjle = new System.IO.StreamReader("q");
            while ((line = fjle.ReadLine()) != null)
            {
                q[counter] = line;
                counter++;
            } fjle.Close();
            counteru = 0;
            Console.WriteLine(" ");
            System.IO.StreamReader fjl = new System.IO.StreamReader("say");
            while ((line = fjl.ReadLine()) != null)
            {
                say[counteru] = line;
                counteru++;
            } fjl.Close();

            Console.WriteLine("Displaying:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            foreach (var item in say)
            {
                Console.WriteLine(item);
            }
            Console.Clear();
        }
        public static void writeq(string txt) { using (System.IO.StreamWriter file = new System.IO.StreamWriter("q", true)) { file.WriteLine(txt); } }
        public static void writesay(string txt) { using (System.IO.StreamWriter file = new System.IO.StreamWriter("say", true)) { file.WriteLine(txt); } }
        public static void learn(string que)
        {
            //Console.WriteLine(say.Length);
            // say = new string[say.Length+1];
            //say[say.Length] = wotsay;
            writesay(wotsay);
            writeq(que);

        }
        public static void reply(string wha, string rawans)
        {
            int no = 0; bool has = false; string[] answer = rawans.Split('`'); string[] replytowhat = wha.Split('`'); Random rnd = new Random(); int rand = rnd.Next(answer.Length);
        /*BREAK --------- mooooooo -------------*/dai:
            if (Array.Exists<string>(replytowhat, (Predicate<string>)delegate(string s) { return wotsay.ToLower().IndexOf(s, StringComparison.OrdinalIgnoreCase) > -1; }))
            { Console.Clear(); Console.WriteLine(answer[rand]); no = 0; caller(MainClass, MainMethod); }
            {
                Console.Clear();/*exep(1);*/
                no++; if (no < 20) { goto dai; } else if (no > 20) { Console.ForegroundColor = ConsoleColor.Red; exep(1); ;no = 0; /*Main();*/ }
                // Environment.Exit(1);
            }
        }

    }
}
