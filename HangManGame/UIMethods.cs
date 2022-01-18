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
        public static void WelcomeMessage(int remAttempts, string level, string difficulty)
        {
            Console.WriteLine($"  Welcome to Hang Man! Level {level} \n\n**{difficulty} Difficulty** \n");
            Console.WriteLine($"Please choose a letter, you have {remAttempts} guesses.\n");
        }
        /// <summary>
        /// Gets user input
        /// </summary>
        /// <returns>Returns user input</returns>
        public static string GetInput()
        {
            //do validity check here, if invalid repeat input (probly while loop)
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
        public static void BeatLvlMessage (string level, int score)
        {
            Console.WriteLine($"Congratulations! you beat level {level}! your score is {score} points");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();           
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
        /// <summary>
        /// Displays winning message and score
        /// </summary>
        /// <param name="score"></param>
        public static void BeatGameMessage(int score)
        {
            Console.WriteLine($"Congratulations! you Win!! your score is {score} points");            
            Console.WriteLine("Would you like to play again y/n?");          
        }
    }
}
