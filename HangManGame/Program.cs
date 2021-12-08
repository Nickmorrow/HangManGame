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
                //LevelOne 
                
                Random rndLvlOne = new Random();

                string lvlOneWord;
                string lOneInput;

                bool beatLvlOne = false;

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
               
                lvlOneWord = levelOneWords[rndLvlOne.Next(levelOneWords.Count)]; //Randomly selected word from level one list

                int lvlOneAllowedAttempts = 10;
                int lvlOneWrongAttempts = 0;
                int lvlOneRemAttempts = 0;
                int lvlOneRemLetters = 0;
                string lvlOneBlank = "";

                                

                List<string> lvlOneDsply = new List<string>(lvlOneWord.Length); //hangman blank spaces                
                for (int i = 0; i < lvlOneWord.Length; i++)
                {
                    lvlOneDsply.Add("_"); 
                }                              

                while (beatLvlOne == false && lvlOneWrongAttempts <= lvlOneAllowedAttempts)  
                {
                    
                    lvlOneRemAttempts = lvlOneAllowedAttempts - lvlOneWrongAttempts;

                    Console.WriteLine("  Welcome to Hang Man! \n\n**Level One Difficulty** \n");
                    Console.WriteLine($"Please choose a letter, you have {lvlOneRemAttempts} guesses.\n");
                    //Console.WriteLine(lvlOneWord);//for test purposes                                                                                                                                     
                    foreach (string letter in lvlOneDsply)//writes letters in display
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();

                    lOneInput = Console.ReadLine().ToLower();//gets user input
                    
                    if (lvlOneWord.Contains(lOneInput))//checks if letter is in random word
                    {                       
                        
                        char chlOneInput = lOneInput[0];

                        for (int i = 0; i < lvlOneWord.Length; i++)//changes _ to input char, if there are no more _ the game is won
                        {
                            if (lvlOneWord[i].Equals(chlOneInput))
                            {
                                lvlOneDsply[i] = lOneInput;
                            }                           
                        }
                        Console.WriteLine($"Correct!!");
                    }
                    if (lvlOneDsply.Contains("_") == false)
                    {
                        beatLvlOne = true;
                    }
                    if (lvlOneWord.Contains(lOneInput) == false)
                    {
                        lvlOneWrongAttempts++;                       
                        Console.WriteLine($"Incorrect!");
                    }
                    Console.WriteLine("Please press 'Spacebar' to try again.");
                    bool spacebar = Console.ReadKey().Key == ConsoleKey.Spacebar;
                    Console.Clear();
                }

                if (beatLvlOne) 
                {
                    Console.WriteLine("Congratulations! you beat level one!");
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                }


                Console.WriteLine("Would you like to play again y/n?");
                string userAnswer = Console.ReadLine();
                Console.Clear();
                playAgain = userAnswer == yesString; 
            }
        }
    }
}
