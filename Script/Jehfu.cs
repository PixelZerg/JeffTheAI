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
        replya("namaste`hi`howdy`khasto cha`kasto cha`khasto bhakocha`konninchi`", "Ke cha thya! Yo dami din ma hajur khasto hunu'ncha`Eh yarr! Ke cha?`Hello! Hami sunga tha dami weatheru ei rakhekocha hai?`Namaste! Aja ko weatheru kathi dami cha hai?");
        replya("malai thacha`malai thapa ko chu`maile thapayeko cha", "Hai?!!`Auh - timi malai bujchus!`Eh auh - malai thacha timi kasto cha`Ma timi sangai chu tyo wala ma");
        replya("lol`haha`teehee`heehee`ahah`lmao`rofl`lmfao`:d`cx", "kasto hasutne hai?`hasne ramro ho`Eh, alik kati hasutne thyo :/");
        replya("Auh`ho`uh`hai`thei tha`hola`yah`ye`ya", "Positivity bhaneko egdum ramro ho, tapai lai egdum suyoge gurcha`Jailepani yo sunsar lai positively hernu huncha hola");



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
