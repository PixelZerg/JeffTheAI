using System;
public class Program
{public static void Main(){Console.WriteLine("Hello and welcome. My name is Jeff the AI");defs();}
public static void defs(){
	
reply("moo`oink`woof`bark`baa", "mooooooooo!`Indeed, moooo`hahaha LOL moOoooooOOOOoo!");
reply("hello", "Hello there! How are you on this fine day?`Hi dude! What's up?`Howdy! Fine weather we are having don't you agree?`Hello there! Isn't the weather just spectacular today?");

}public static void reply(string wha, string rawans){string[] answer = rawans.Split('`'); string[] replytowhat = wha.Split('`'); foreach(var item in replytowhat){
if(Console.ReadLine().ToLower().Contains(item) == true){Random rnd = new Random();int rand = rnd.Next(answer.Length);Console.WriteLine(answer[rand]);} defs();}
}}
