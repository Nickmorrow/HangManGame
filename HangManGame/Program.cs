using System;

namespace HangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string yesString = "y";

            while (playAgain)
            {






                Console.WriteLine("Would you like to play again y/n?");
                string userAnswer = Console.ReadLine();
             
                playAgain = userAnswer == yesString; // short option playAgain
            }
        }
    }
}
