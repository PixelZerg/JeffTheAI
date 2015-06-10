using System;
using System.Linq;
public class Program
{
    public static string wotsaya; 
    
    public static void Maine() { Console.WriteLine("Namaste ani dunyeibad. Mero nam Jehfa ho"); defsu(); }
    public static void defsu()
    {
        wotsaya = Console.ReadLine();//Console.ForegroundColor = ConsoleColor.Gray;


        replya("moo`oink`bau`bhau`baa", "mooooooooo!`Ho, mooooo`hahaha khasto hasuteyo moOoooooOOOOoo!");
        //-> moo`yes, moo` haha how funny mooooo
        replya("namaste`hi`howdy`khasto cha`kasto cha`khasto bhakocha`konninchi`", "Ke cha thya! Yo dami din ma hajur khasto hunu'ncha`Eh yarr! Ke cha?`Hello! Hami sunga tha dami weatheru ei rakhekocha hai?`Namaste! Aja ko weatheru kathi dami cha hai?");
        //namaste`hi`howdy`how's it`how's it`how's it going`konninchiwa -> how's it there!? On this awesome day how are you doing?`m8! How's it?`Hello! We are having awesome weather right?` Greetings! The weather of today is so awesome right?
        replya("malai thacha`malai thapa ko chu`maile thapayeko cha", "Hai?!!`Auh - timi malai bujchus!`Eh auh - malai thacha timi kasto cha`Ma timi sangai chu tyo wala ma");
        //i know` i have known(?)`i have been knowing(?) -> Right?!! Yeah - you understand me!` Oh yeah - I know you are`I am with you on that one
        replya("lol`haha`teehee`heehee`ahah`lmao`rofl`lmfao`:d`cx", "kasto hasutne hai?`hasne ramro ho`Eh, alik kati hasutne thyo :/");
        // -> how very funny, right?`laughing is good`Oh, it was a bit funny (i couldn't figure out how to say "I suppose")
        replya("Auh`ho`uh`hai`thei tha`hola`yah`ye`ya", "Positivity bhaneko egdum ramro ho, tapai lai egdum suyoge gurcha`Jailepani yo sunsar lai positively hernu huncha hola");
        //Yeah`indeed`yea`right?`exactly`really?`yah`ye`ya -> Positivity is very good, it will service you a lot`May you always look at/upon this world positively



    }
    public static void replya(string wha, string rawans)
    {
        int no = 0; bool has = false; string[] answer = rawans.Split('`'); string[] replyatowhat = wha.Split('`');Random rnd = new Random(); int rand = rnd.Next(answer.Length);
        /*BREAK --------- mooooooo -------------*/dai:
        if (Array.Exists<string>(replyatowhat,(Predicate<string>)delegate(string s){return wotsaya.ToLower().IndexOf(s,StringComparison.OrdinalIgnoreCase)>-1;}))
        { Console.Clear(); Console.WriteLine(answer[rand]); no = 0; defsu(); }
        {
            Console.Clear(); Console.WriteLine("Thesto khalko kura malai theti dherae munpurdaina :/");
            no++;if(no<20){goto dai;}else if(no>20){Console.WriteLine("Thesto khalko kura malai theti dherae munpurdaina :/");no=0;Maine();}}}}
