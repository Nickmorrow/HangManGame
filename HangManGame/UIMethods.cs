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
        public static void WelcomeMessage(int remAttempts, string level)
        {
            Console.WriteLine($"  Welcome to Hang Man! Level {level} \n\n**Easy Difficulty** \n");
            Console.WriteLine($"Please choose a letter, you have {remAttempts} guesses.\n");
        }
        /// <summary>
        /// Gets user input
        /// </summary>
        /// <returns>Returns user input</returns>
        public static string GetInput()
        {
            string input = Console.ReadLine().ToLower();
            return input;
        }
        /// <summary>
        /// Lets the user decide if they want to try again
        /// </summary>
        public static bool TryAgain()
        {
            Console.WriteLine("Please press 'Enter' to try again.");
            bool enter = Console.ReadKey().Key == ConsoleKey.Enter;         
            Console.Clear();
            return enter;
        }
        /// <summary>
        /// States that the guess was correct
        /// </summary>
        public static void Correct ()
        {
            Console.WriteLine($"Correct!!");
        }
        /// <summary>
        /// States that the guess was incorrect
        /// </summary>
        public static void Incorrect ()
        {
            Console.WriteLine($"Incorrect!");
        }
        /// <summary>
        /// Displays message stating that the user has beaten the level, lets the user decide if they want to play again
        /// </summary>
        /// <param name="level"></param>
        /// <param name="score"></param>
        public static bool BeatLvlMessage (string level, int score)
        {
            Console.WriteLine($"Congratulations! you beat level {level}! your score is {score} points");
            Console.WriteLine("Please press 'Spacebar' continue.");
            bool spaceBar = Console.ReadKey().Key == ConsoleKey.Spacebar;
            Console.Clear();
            return spaceBar;
        }
        /// <summary>
        /// Displays game over message and asks user if they want to play again
        /// </summary>
        /// <param name="yesString"></param>
        public static void GameOver ()
        {
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Would you like to play again y/n?");           
        }
    }
}
