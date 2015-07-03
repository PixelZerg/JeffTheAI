using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l337
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's translate!!");
            Console.ForegroundColor = ConsoleColor.Gray;
            /*line*/
            string wotsay = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("l337");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(l337(wotsay));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("reverse");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(reverse(wotsay));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("l337 then reverse");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(reverse(l337(wotsay)));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("reverse then l337");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(l337(reverse(wotsay)));
            Console.ForegroundColor = ConsoleColor.Gray;
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


        public static void linew(char symbol)
        {
            int tmp = Console.WindowWidth;
            while (tmp != 0)
            {
                Console.Write(symbol.ToString());
                tmp--;
            }
        }
    }
}
