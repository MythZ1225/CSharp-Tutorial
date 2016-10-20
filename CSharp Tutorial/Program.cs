using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4; // 電腦設定            
            int guess;

            Console.WriteLine("Want play a game?");
            Console.WriteLine("a num between 1~10?");
            Console.WriteLine("what is it?");

            do
            {
                string guessString = Console.ReadLine();
                Console.WriteLine("your guess is " + guessString);

                try
                {
                    guess = int.Parse(guessString);

                }
                catch (Exception e)
                {
                    Console.WriteLine("That's not a Num!");
                    Console.WriteLine("The Error was " + e);
                    return;
                }
                if (answer == guess)
                {
                    Console.WriteLine("You R correct");

                }
                else if (answer > guess)
                {
                    Console.WriteLine("you need a bigger Num");
                }
                else
                {
                    Console.WriteLine("you need a smaller Num");
                }
            }
            while (answer != guess);          
        }
    }
}
