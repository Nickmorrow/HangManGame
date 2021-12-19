using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManGame
{
    public static class UIMethods
    {
        
        /// <summary>
        /// Displays welcome message and number of remaining attempts.
        /// </summary>
        /// <param name="remAttempts"></param>
        public static void WelcomeMessage(int remAttempts)
        {
            Console.WriteLine("  Welcome to Hang Man! Level One \n\n**Easy Difficulty** \n");
            Console.WriteLine($"Please choose a letter, you have {remAttempts} guesses.\n");
        }
        //public static string GetInput(string input)
        //{
        //    input = Console.ReadLine().ToLower();
        //    return input;
        //}
        public static void TryAgain()
        {
            Console.WriteLine("Please press 'Enter' to try again.");
            bool enter = Console.ReadKey().Key == ConsoleKey.Enter;
            Console.Clear();
        }
    }
}
