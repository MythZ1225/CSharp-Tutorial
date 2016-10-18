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
            string answer = "4"; // 電腦設定
        

            Console.WriteLine("Want play a game?");
            Console.WriteLine("a num between 1~10?");
            Console.WriteLine("what is it?");

            bool userWasNotRight = true;

            while (userWasNotRight) {
                String guess = Console.ReadLine();

                Console.WriteLine("your guess is " + guess);
               
                if (answer == guess)
                {
                    Console.WriteLine("You R correct");
                    userWasNotRight = false;
                }
                else
                {
                    Console.WriteLine("Missed! Try again!");
                }
            }

            

        }
    }
}
