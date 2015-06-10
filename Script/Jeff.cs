using System;
using System.Linq;
public class Program{public static string wotsay;public static void Main(){Console.WriteLine("Hello and welcome. My name is Jeff the AI");defs();}
public static void defs(){wotsay = Console.ReadLine();//Console.ForegroundColor = ConsoleColor.Gray;
        reply("moo`oink`woof`bark`baa", "mooooooooo!`Indeed, moooo`hahaha LOL moOoooooOOOOoo!");
        reply("hello`hi", "Hello there! How are you on this fine day?`Hi dude! What's up?`Howdy! Fine weather we are having don't you agree?`Hello there! Isn't the weather just spectacular today?");
        reply("ikr`i know`right?", "Right?!!`Yeah - you get me!`Oh yeah - I know the feels`I'm totally with you on that one!");
        reply("lol`haha`teehee`heehee`ahah`lmao`rofl`lmfao`:d`c:`cx", "Much funny, much laugh`it's good to be happy c:`that was rather funny I suppose ;]");
    }public static void reply(string wha, string rawans){int no = 0; bool has = false; string[] answer = rawans.Split('`'); string[] replytowhat = wha.Split('`');Random rnd = new Random(); int rand = rnd.Next(answer.Length);/*BREAK --------- mooooooo -------------*/dai:
if (Array.Exists<string>(replytowhat,(Predicate<string>)delegate(string s){return wotsay.IndexOf(s,StringComparison.OrdinalIgnoreCase)>-1;})){Console.Clear();Console.WriteLine(answer[rand]);no=0;defs();}{Console.Clear();Console.WriteLine("That subject doesn't really intrest me :/");
no++;if(no<10){goto dai;}else if(no>10){Console.WriteLine("That subject doesn't intrest me :/");no=0;Main();}}}}
