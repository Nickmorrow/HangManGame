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
                levelOneWords.Add("doritos");
                levelOneWords.Add("bloody");
                levelOneWords.Add("chair");
                levelOneWords.Add("death");
                levelOneWords.Add("enemies");
                levelOneWords.Add("gross");
                levelOneWords.Add("laser");
                levelOneWords.Add("queen");
                levelOneWords.Add("spider");
                levelOneWords.Add("wheelie");

                Random rndLvlOne = new Random();
                string lvlOneWord = levelOneWords[rndLvlOne.Next(levelOneWords.Count)]; //Randomly selected word from level one list

                int lvlOneAllowedAttempts = 9;
                int lvlOneWrongAttempts = 0;
                int lvlOneRemAttempts = 0;
                int lvlOneRemLetters = lvlOneWord.Length;
                string lvlOneBlank = "";

                List<string> lvlOneDsply = new List<string>(); //hangman blank spaces
                lvlOneDsply.Add("_");
                for (int i = 0; i < lvlOneWord.Length; i++)
                {
                    lvlOneDsply.Add("_");
                    lvlOneBlank = lvlOneBlank + lvlOneDsply[i];
                }
                
                Console.WriteLine("Welcome to Hang Man! \n\nLevel One Difficulty \n");

                while (lvlOneWord != lvlOneBlank && lvlOneWrongAttempts <= lvlOneAllowedAttempts)  
                {
                    Console.WriteLine(lvlOneWord);//for test purposes

                    lvlOneRemAttempts = lvlOneAllowedAttempts - lvlOneWrongAttempts;                  
                    
                    Console.WriteLine(lvlOneBlank);
                    Console.WriteLine("\nPlease guess a letter\n");
                    
                    string lOneInput = Console.ReadLine().ToLower();
                    char cLOneInput = char.Parse(lOneInput);
                    
                    for (int i = 0;i < lvlOneWord.Length;i++) //(Not Working) checks each letter of lvlOneWord for input and changing the corresponding _ of lvlOneBlank 
                    {                       
                        if (lvlOneWord[i] == cLOneInput)
                        {
                            lvlOneDsply[i] = lOneInput;                           
                        }
                    }
                    if (lvlOneWord.Contains(lOneInput))
                    {                       
                        Console.WriteLine($"Nice Guess!!");
                    }
                    else
                    {
                        lvlOneWrongAttempts++;
                        Console.WriteLine($"The word does not contain that letter, you have {lvlOneRemAttempts} chances left.");
                    }

                }

                if (lvlOneWord == lvlOneBlank) 
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
