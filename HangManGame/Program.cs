using System;
using System.Collections.Generic;
using System.Linq;

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
                List<string> levelOneWords = new List<string>(); //List of words for level one difficulty              

                levelOneWords.Add("agent");
                levelOneWords.Add("blood");
                levelOneWords.Add("chair");
                levelOneWords.Add("death");
                levelOneWords.Add("enemy");
                levelOneWords.Add("gross");
                levelOneWords.Add("laser");
                levelOneWords.Add("queen");
                levelOneWords.Add("smoke");
                levelOneWords.Add("wheel");

                Random rndLvlOne = new Random();
                string lvlOneWord = levelOneWords[rndLvlOne.Next(levelOneWords.Count)]; //Randomly selected word from level one list

                int lvlOneAllowedAttempts = 9;
                int lvlOneWrongAttempts = 0;
                int lvlOneRemAttempts = 0;
                int lvlOneRemLetters = 5;
                char[] lvlOneDsply = {'_','_','_','_','_'};

                Console.WriteLine(lvlOneDsply.ToString());

                Console.WriteLine("Welcome to Hang Man! \n\nLevel One Difficulty \n");

                while (lvlOneWord != lvlOneDsply.ToString() && lvlOneWrongAttempts <= lvlOneAllowedAttempts)  //DANGER: .ToString doesn't do what you might think!
                {
                    Console.WriteLine(lvlOneWord);//for test purposes

                    lvlOneRemAttempts = lvlOneAllowedAttempts - lvlOneWrongAttempts;                  
                    Console.WriteLine(lvlOneDsply);
                    Console.WriteLine("\nPlease guess a letter\n");
                    string input = Console.ReadLine();
                    
                    if (lvlOneWord.Contains(input))
                    {
                        lvlOneRemLetters--;
                        int letterIndex = lvlOneWord.IndexOf(input);
                        lvlOneDsply[letterIndex] = input.ToCharArray()[letterIndex]; //Error: selects only first letter all others char[5] can only select one letter if there are two of same 
                        Console.WriteLine($"Congrats! only {lvlOneRemLetters} left!");
                    }
                    else
                    {
                        lvlOneWrongAttempts++;
                        Console.WriteLine($"The word does not contain that letter, you have {lvlOneRemAttempts} chances left.");
                    }

                }

                if (lvlOneWord == lvlOneDsply.ToString()) //DANGER: .ToString doesn't do what you might think!
                {
                    Console.WriteLine("Congratulations! YOU WIN!");
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                }


                Console.WriteLine("Would you like to play again y/n?");
                string userAnswer = Console.ReadLine();
             
                playAgain = userAnswer == yesString; 
            }
        }
    }
}
