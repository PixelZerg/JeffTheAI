using System;
					
public class Program
{
	public static void Main()
	{
		string[] array;
		
		Console.WriteLine("Hello and welcome. My name is Jeff the AI");
		
		/*if(Console.ReadLine().ToLower().Contains("moo") == true){Console.WriteLine("moo to you too, fella!");}
		if(Console.ReadLine().ToLower().Contains("hello") == true){
			Random rnd = new Random();
			int rand = rnd.Next(2);
			if(rand == 0){ Console.WriteLine("Hello there dude! Awesome weather we're having - do you not agree?"); }
			if(rand == 1){ Console.WriteLine("Hi! How are you doing?");}*/
		array = new string[2];
		array[0] = "Moo to you too!";
		array[1] = "I agree, moo indeed";
		reply("moo", array);
		}
			

		
		public static void reply(string replytowhat, string[] answer)
		{
			if(Console.ReadLine().ToLower().Contains(replytowhat) == true){
			Random rnd = new Random();
			int rand = rnd.Next(answer.Length);
				int no = 0;
				/*foreach(var item in answer){
					if(no == rand){
						//do the answer
						Console.WriteLine(item);
						//no++;
					} else {
						no++;
					}
				}*/
				Console.WriteLine(answer[rand]);
		}
			
}
}
