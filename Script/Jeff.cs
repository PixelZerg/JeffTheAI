using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello and welcome. My name is Jeff the AI");if(Console.ReadLine().ToLower().Contains("moo") == true){Console.WriteLine("moo to you too, fella!");}
		if(Console.ReadLine().ToLower().Contains("hello") == true){
			Random rnd = new Random();
			int rand = rnd.Next(2);
			if(rand == 0){ Console.WriteLine("Hello there dude! Awesome weather we're having - do you not agree?"); }
			if(rand == 1){ Console.WriteLine("Hi! How are you doing?");}
		}
			
	}
}
