﻿using System;
using System.IO;
using System.Linq;
public class Program
{
    public static string wotsay;
    public static string[] say = new string[0];
    public static string[] q = new string[0];
    public static bool wait = false;
    public static string final;

    public static bool thereforemode = false;
    public static bool leetmode = false;
    public static bool reversemode = false;

    //public static int qmax = 0;
    public static void Main() {
        if(System.IO.File.Exists("q") == false){
        System.IO.File.WriteAllText("q","");System.IO.File.WriteAllText("say","");}
        Console.ForegroundColor = ConsoleColor.Yellow;
        scan(); hello(); }

    public static void fin(string txt)
    {
            if (thereforemode == true)
            {
                Console.Clear();
                Console.Write("Either way, therefore, " + txt + Environment.NewLine);
            }
            else
             if (leetmode == true)
            {
                Console.Clear();
                Console.WriteLine(l337(txt));
            }
             else

                 if (reversemode == true)
                 {
                     Console.Clear();
                     Console.WriteLine(reverse(txt));
                 }
                 else
                 {
                     Console.Clear();
                     Console.WriteLine(txt);
                 }
    }

    public static void hello()
    {
        Console.WriteLine("Hello! I'm Jeff the AI");
        /*
        wotsay = Console.ReadLine();
        learn("hello");
        Console.Clear();
        ChangeSubject();
         */
        defs();
    }
    public static void defs()
    {
       // green();
        Console.ForegroundColor = ConsoleColor.Gray;
        wotsay = Console.ReadLine();//Console.ForegroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Yellow;
        /*
        reply("moo`oink`woof`bark`baa", "mooooooooo!`Indeed, moooo`hahaha LOL moOoooooOOOOoo!");
        reply("hi`howdy`what's up`wassup`wazzup`konninchi`namaste`ohio`bonjour`good day`guten tag`ni hao`salut", "Hello there! How are you on this fine day?`Hi dude! What's up?`Howdy! Fine weather we are having don't you agree?`Hello there! Isn't the weather just spectacular today?");
        reply("ikr`i know`right?", "Right?!!`Yeah - you get me!`Oh yeah - I know the feels`I'm totally with you on that one!");
        reply("lol`haha`teehee`heehee`ahah`lmao`rofl`lmfao`:d`cx", "Much funny, much laugh`it's good to be happy c:`that was rather funny I suppose ;]");
        reply("yeah`yep`indeed`exactly`ofc`yes`yah`ye`ya", "Positivity is very good`Be positive and it'll do you good!`Always look upon the world with positive eyes");
        reply("ofc`of course`:)`correct`tru`:>`:]`:}`ok", "Positivity is very good`Be positive and it'll do you good!`Always look upon the world with positive eyes");
         */

        //special replies:
        if (wotsay == " " || wotsay == null || wotsay == "") { Console.WriteLine("..."); defs(); }
        if (wotsay.ToLower().Contains("code")) { Console.WriteLine("Did somebody say code?!"); Console.ReadKey(); green(); Console.Clear(); defs(); };
        if (wotsay.ToLower().Contains("wait")) { Console.WriteLine("WAIT = " + !wait); wait = !wait; defs(); };
        if (wotsay.ToLower().Contains("rectangle") == true && wotsay.ToLower().Contains("draw") == true) { Console.Clear();  fin("let's draw a rectangle. Please enter the following seperated by commas: x, y, width, height"); pause(700); rectangle(); };
        if (wotsay.ToLower().Contains("therefore") == true && wotsay.ToLower().Contains("either") == true && wotsay.ToLower().Contains("way") == true) { Console.WriteLine("Either way, therefore, I think that is very interesting"); thereforemode = !thereforemode; }
        if (wotsay.ToLower().Contains("leet") == true || wotsay.ToLower().Contains("337") == true || wotsay.ToLower().Contains("33+") == true || wotsay.ToLower().Contains("33t") == true) { leetmode = !leetmode; exep(1); };

        #region learn
        if (wotsay == "learn")
        {
            Console.WriteLine("Welcome to the Learning Wizzard - here you can teach me new words."); 
            fin("If you say text to me that contains a keyword - you can tell me what to reply to it with");
            Console.WriteLine("Oh and also - you can define multiple keywords - the answer shall be done for any of the keywords");
            Console.WriteLine("and you can do multiple answers too - a random answer will be given...");
            Console.WriteLine("seperate them by a '`' sign");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Enter Keyword(s):");
            Console.ForegroundColor = ConsoleColor.Gray;
            string tmp1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            writeq(tmp1.ToLower());
            Console.WriteLine("Enter Reply(s):");
            Console.ForegroundColor = ConsoleColor.Gray;
            string tmp2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            writesay(tmp2);
            Console.Clear();
            Console.WriteLine("Got it! From now on, if you say something to me that contains '" + tmp1.ToLower() + "' in it, I shall reply with '" + tmp2 + "'");
            scan();
            defs();
        }
        #endregion
        #region random
        if (wotsay.ToLower().Contains("random") == true)
        {
            ChangeSubject();
        }
        #endregion
        //if it still is not redirected by now, that means it's exeption no.1
        exep(1);}

    public static void rectangle()
    {
        Console.WriteLine("Enter parameters:");
        string input = Console.ReadLine();
        string[] splitinput = input.Split(',');
        if (splitinput.Length != 4)
        {
            fin("error not enough args");
        }
        else
        {
            if (splitinput[0] == "") { splitinput[0] = "0"; }
            if (splitinput[1] == "") { splitinput[1] = "0"; }
            if (splitinput[2] == "") { splitinput[2] = "0"; }
            if (splitinput[3] == "") { splitinput[3] = "0"; }
            rect(Int32.Parse(splitinput[0]), Int32.Parse(splitinput[1]), Int32.Parse(splitinput[2]), Int32.Parse(splitinput[3]));
        }
        pause(5000);
        fin("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        defs();
    }
    public static void rect(int x, int y, int width, int height)
    {

        var tmp = Console.WindowWidth;
        while (tmp != 0)
        {
            Console.Write("-");
            tmp--;
        }
        Console.Write(Environment.NewLine);
        var tmpWidth = width;
        var tmpHeight = height;
        //offset
        var tmpx = x;
        var tmpy = y;
        while (tmpy != 0)
        {
            Console.Write(Environment.NewLine);
            tmpy--;
        }
        while (tmpx != 0)
        {
            Console.Write(" ");
            tmpx--;
        }
        Console.Write(" ");
        //top bit
        while (tmpWidth != 0)
        {
            Console.Write("-");
            tmpWidth--;
        }
        //middle bit
        tmpWidth = width;
        while (tmpHeight != 0)
        {
            //offset
            Console.Write(Environment.NewLine);
            tmpx = x;
            while (tmpx != 0)
            {
                Console.Write(" ");
                tmpx--;
            }
            Console.Write("|");
            //do spaces + "|"
            var tmptmpWidth = width;
            while (tmptmpWidth != 0)
            {
                Console.Write(" ");
                tmptmpWidth--;
            }
            Console.Write("|");
            tmpHeight--;
        }
        //bottom bit
        Console.Write(Environment.NewLine);
        //offset
        tmpx = x;
        while (tmpx != 0)
        {
            Console.Write(" ");
            tmpx--;
        }
        Console.Write(" ");
        tmpWidth = width;
        while (tmpWidth != 0)
        {
            Console.Write("-");
            tmpWidth--;
        }
        Console.WriteLine("");

        //do bottom line
        tmp = Console.WindowHeight - height - y - 10;
        while (tmp != 0)
        {
            Console.Write(Environment.NewLine);
            tmp--;
        }
        tmp = Console.WindowWidth - 2;
        Console.Write(" ");
        while (tmp != 0)
        {
            Console.Write("_");
            tmp--;
        }
        Console.Write(" ");
        Console.Write(Environment.NewLine);
    }
    public static void pause(int time)
    {
        if (wait == true)
        {
            TimeSpan timeout = TimeSpan.FromMilliseconds(time);
            DateTime start_time = DateTime.Now;
            while (DateTime.Now - start_time < timeout) { }
        }
    }
    public static void exep(int no)
    {
        //Console.WriteLine("EXCEPTION");
        //check
        if (no == 69) { fin("A WTF exception has occured! Application will now exit"); Environment.Exit(1); }
        if(no == 1){recite();} //this is a 'dunno what to say' exeption so see if .jeff files have anything
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
                else {
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
    public static void ChangeSubject()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
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
        if (six == 1) { wh7 = "who"; }
        if (six == 2) { wh7 = "what"; }
        if (six == 3) { wh7 = "when"; }
        if (six == 4) { wh7 = "where"; }
        if (six == 5) { wh7 = "why"; }
        if (six == 6) { wh7 = "how"; }
        if (six > 6 || six < 1) { wh7 = "why"; }

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
        Console.Write(" " + art + " ");
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
        Console.Clear();
        fin("this is interesting... however - this leads me to wonder... " + wh7 + " " + art + " " + Environment.NewLine + nom + stat);
        Console.ForegroundColor = ConsoleColor.Yellow;
        defs();
    }
    public static void green()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        #region first bit
        var rnd = new Random();
        int lrand = rnd.Next(150);
        int hrand = rnd.Next(350);
        pause(hrand);
        Console.Write("if (Array.Exists<string>");
        lrand = rnd.Next(150);
        hrand = rnd.Next(350);
        pause(hrand);
        Console.Write("replytowhat,(Predicate<string>)delegate(string s)");
        lrand = rnd.Next(150);
        hrand = rnd.Next(350);
        pause(lrand);
        Console.Write("{return wotsay.ToLower().IndexOf(s,StringComparison.OrdinalIgnoreCase)>-1;}))");
        lrand = rnd.Next(150);
        hrand = rnd.Next(350);
        pause(lrand);
        Console.Write("{Console.Clear();Console.WriteLine(answer[rand]);no=0;defs();}");
        lrand = rnd.Next(150);
        hrand = rnd.Next(350);
        pause(lrand);
        Console.Write("{Console.Clear();/*exep(1);*/no++; if (no < 20) { goto dai; } else if (no > 20)");
        lrand = rnd.Next(150);
        hrand = rnd.Next(350);
        pause(hrand);
        Console.Write("{ Console.ForegroundColor = ConsoleColor.Red;  exep(1); ;no = 0; /*Main();*/ }");
        pause(hrand);
#endregion
        foreach (var item in q)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            Console.Write(raa + item + q + rand);
            pause(raa/2);
        }
        foreach (var item in q)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            if (raa > 400)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(raa + item + q + rand);
            pause(raa / 2);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        say:
        #region say
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 / 2;
            Console.WriteLine(say[rao] + "" + raa + one + "o" + "SYSTEM.READ[" + two + "]");
            pause(raa / 2);
        }
        #endregion
        q:
        #region q
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(300);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao +"r" +"]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(200);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(100);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(30);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(200);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(500);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        foreach (var item in say)
        {
            var rand = new Random();
            int raa = rand.Next(100);
            int rao = rand.Next(say.Length);
            var one = raa / 3 ^ 2;
            var two = raa - 30 ^ 2;
            Console.WriteLine(say[rao] + "SYSTEM.[" + rao + "r" + "]" + one + "o" + "SYSTEM.READ[" + two + "]" + item);
            pause(raa / 2);
        }
        #endregion
        var rando = new Random();
        int rndo = rando.Next(10);
        if (rndo <= 2)
        {
            if (rndo <= 1)
            {
                goto q;
            }
            else
            {
                goto say;
            }
        }
        else {  }
    }
    public static void scan()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Scanning .jeff files:");
        pause(300);
        int counter = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader("q");
        while ((line = file.ReadLine()) != null){
            //Console.WriteLine(counter.ToString() + " | " + line);
            counter++;}file.Close();
        int counteru = 0;
        Console.WriteLine(" ");
        file.Close();
        System.IO.StreamReader fil = new System.IO.StreamReader("say");
        while ((line = fil.ReadLine()) != null){
           // Console.WriteLine(counteru.ToString() + " | " + line);
            counteru++;}fil.Close();
        if (counter > counteru || counter < counteru)
        {
            Console.WriteLine("Invalid .jeff files! Cannot load");
            Environment.Exit(1);
        }
        //else continue forth to store vars:
        Console.WriteLine(".jeff files found!");
        Console.WriteLine("no. args = " + counteru);
        pause(300);
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
        pause(300);
        foreach (var item in q)
        {
            pause(70);
            Console.WriteLine(item);
        }
        foreach (var item in say)
        {
            pause(30);
            Console.WriteLine(item);
        }
        pause(700);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    public static void writeLearn(string txt, string tsay)
    {
        /*
        #region read
       // qmax = File.ReadAllLines("q").Length;

        int line = 0;
        while (line != qmax)
        {
            int readline = line - 0;
            string qraw = File.ReadLines("q").Skip(readline).Take(1).First();
            // Console.WriteLine("Reading line " + line + " of " + qmax);

            string[] q = qraw.Split('`');
            int args = q.Count();
            foreach (var item in q)
            {
                Console.WriteLine(item);
                if (item.ToLower().Contains(txt.ToLower()) == true)
                {
                            //we have a match! so leave it
                            //count lines in 2nd file
                   int smax = File.ReadAllLines("say").Length;
                    //read corresponding line in file
                    string sraw = File.ReadLines("say").Skip(readline).Take(1).First();
                    Console.WriteLine(sraw);
                    }
                else
                {
                    //write line
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("q", true))
                    {
                        file.WriteLine(txt);
                        defs();
                    }
                }
            }
            line++;
            }
        
        #endregion
        */
    } /*deccapretatdetd*/
    public static void writeq(string txt)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter("q", true))
        {
            file.WriteLine(txt);
        }
    }
    public static void writesay(string txt)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter("say", true))
        {
            file.WriteLine(txt);
        }
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
    public static void learn(string que)
    {
        //Console.WriteLine(say.Length);
       // say = new string[say.Length+1];
        //say[say.Length] = wotsay;
        writesay(wotsay.ToLower());
        writeq(que.ToLower());
        Console.WriteLine("LEARNT: " + que + " = " + wotsay);
        pause(500);

    }
    public static void reply(string wha, string rawans)
    {
        int no = 0; bool has = false; string[] answer = rawans.Split('`'); string[] replytowhat = wha.Split('`');Random rnd = new Random(); int rand = rnd.Next(answer.Length);
        /*BREAK --------- mooooooo -------------*/dai:
        if (Array.Exists<string>(replytowhat,(Predicate<string>)delegate(string s){return wotsay.ToLower().IndexOf(s,StringComparison.OrdinalIgnoreCase)>-1;}))
        {Console.Clear();Console.WriteLine(answer[rand]);no=0;defs();}{Console.Clear();/*exep(1);*/
        no++; if (no < 20) { goto dai; } else if (no > 20) { Console.ForegroundColor = ConsoleColor.Red;  exep(1); ;no = 0; /*Main();*/ }
       // Environment.Exit(1);
        }
    }

    //protocols & filters & general non-void functions
    public static void synonyms(string txt)
    {
        #region thesaurus jagarray

        string[][] jagarray = new string[4][];

        jagarray[0] = new string[] {"nice", "excellent", "awesome", "outstanding", "great", "good", "exceptional", "positive", "marvelous", "ace"};
        jagarray[1] = new string[] { "bad", "terrible", "horrible", "poor", "aweful", "dreadful", "unacceptable" };
        jagarray[2] = new string[] { "incredibly", "outstandingly", "extremely", "very", "geniuinely", "immensely", "greatly", "notably" };
        jagarray[3] = new string[] { "in fact", "to be fact", "to be frank" };

        #endregion

        string[] stxt = txt.Split(' ');

        int num = 0;
        foreach (string str in stxt)
        {
            foreach (string[] astring in jagarray)
            {foreach (string jagstr in astring)
                {if (str.ToLower().Contains(jagstr) == true)
                    {
                        #region replace
                        var rand = new Random();
                        int rnd = rand.Next(astring.Length);
                        stxt[num] = astring[rnd];
                        #endregion
                    }}}
            num++;
        }
    }
    public static string l337(string txt)
    {
        string[] fin = new string[txt.Length];
        int num = 0;
        foreach (var qw in txt.ToLower())
        {
            //Console.WriteLine(item);
            if (qw == 'a') { fin[num] = "@"; }
            if (qw == 'b') { fin[num] = "8"; }
            if (qw == 'c') { fin[num] = "("; }
            if (qw == 'd') { fin[num] = "c!"; }
            if (qw == 'e') { fin[num] = "3"; }
            if (qw == 'f') { fin[num] = "/="; }
            if (qw == 'g') { fin[num] = "6"; }
            if (qw == 'h') { fin[num] = "|-|"; }
            if (qw == 'i') { fin[num] = "1"; }
            if (qw == 'j') { fin[num] = ";"; }
            if (qw == 'k') { fin[num] = "|<"; }
            if (qw == 'l') { fin[num] = "|"; }
            if (qw == 'm') { fin[num] = "|\\/|"; }
            if (qw == 'n') { fin[num] = "|\\|"; }
            if (qw == 'o') { fin[num] = "0"; }
            if (qw == 'p') { fin[num] = "|>"; }
            if (qw == 'q') { fin[num] = "?"; }
            if (qw == 'r') { fin[num] = "|2"; }
            if (qw == 's') { fin[num] = "5"; }
            if (qw == 't') { fin[num] = "7"; }
            if (qw == 'u') { fin[num] = "|_|"; }
            if (qw == 'v') { fin[num] = "\\/"; }
            if (qw == 'w') { fin[num] = "\\|//"; }
            if (qw == 'x') { fin[num] = "><"; }
            if (qw == 'y') { fin[num] = "`/"; }
            if (qw == 'z') { fin[num] = "7_"; }
            if (qw == ' ') { fin[num] = "_"; }
            num++;
        }
        var final = string.Join("", fin);

        return final;
    }
    public static string reverse(string txt)
    {
        string[] letters = new string[txt.Length + 1];
        int num = 0;
        foreach (var item in txt)
        {
            int tmp = txt.Length - num;
            letters[tmp] = item.ToString();
            num++;
        }
        var final = string.Join("", letters);
        return final;
    }
}