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
            int score = 0;

            while (playAgain)
            {
                //LevelOne Easy-------------------------------------------------------------------------------
                
                Random rndLvlOne = new Random();

                string lvlOneWord;
                string lOneInput;

                bool beatLvlOne = false;

                List<string> levelOneWords = new List<string>(); //List of words for Easy difficulty              
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

                    Console.WriteLine("  Welcome to Hang Man! Level One \n\n**Easy Difficulty** \n");
                    Console.WriteLine($"Please choose a letter, you have {lvlOneRemAttempts} guesses.\n");
                                                                                                                                                         
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
                    score = lvlOneRemAttempts;
                    Console.WriteLine($"Congratulations! you beat level one! your score is {score} points");
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                }                

                Console.WriteLine("Would you like to play the next level y/n?");
                string lOneuserAnswer = Console.ReadLine();
                Console.Clear();
             
                //LevelTwo------------------------------------------------------------------------------------------------------- 

                Random rndLvlTwo = new Random();

                string lvlTwoWord;
                string lTwoInput;

                bool beatLvlTwo = false;

                List<string> levelTwoWords = new List<string>(); //List of words for level one difficulty              
                levelTwoWords.Add("business");
                levelTwoWords.Add("Elephant");
                levelTwoWords.Add("Sandwich");
                levelTwoWords.Add("Violence");
                levelTwoWords.Add("November");
                levelTwoWords.Add("habaneros");
                levelTwoWords.Add("macadamia");
                levelTwoWords.Add("abandoned");
                levelTwoWords.Add("Government");
                levelTwoWords.Add("Restaurant");

                lvlTwoWord = levelTwoWords[rndLvlTwo.Next(levelTwoWords.Count)]; //Randomly selected word from level one list

                int lvlTwoAllowedAttempts = 10;
                int lvlTwoWrongAttempts = 0;
                int lvlTwoRemAttempts = 0;
                int lvlTwoRemLetters = 0;

                List<string> lvlTwoDsply = new List<string>(lvlTwoWord.Length); //hangman blank spaces                
                for (int i = 0; i < lvlTwoWord.Length; i++)
                {
                    lvlTwoDsply.Add("_");
                }

                while (beatLvlTwo == false && lvlTwoWrongAttempts <= lvlTwoAllowedAttempts)
                {

                    lvlTwoRemAttempts = lvlTwoAllowedAttempts - lvlTwoWrongAttempts;

                    Console.WriteLine("  Welcome to Hang Man! Level Two \n\n**Intermediate Difficulty** \n");
                    Console.WriteLine($"Please choose a letter, you have {lvlTwoRemAttempts} guesses.\n");
                                                                                                                                                        
                    foreach (string letter in lvlTwoDsply)//writes letters in display
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();

                    lTwoInput = Console.ReadLine().ToLower();//gets user input

                    if (lvlTwoWord.Contains(lTwoInput))//checks if letter is in random word
                    {

                        char chlTwoInput = lTwoInput[0];

                        for (int i = 0; i < lvlTwoWord.Length; i++)//changes _ to input char, if there are no more _ the game is won
                        {
                            if (lvlTwoWord[i].Equals(chlTwoInput))
                            {
                                lvlTwoDsply[i] = lTwoInput;
                            }
                        }
                        Console.WriteLine($"Correct!!");
                    }
                    if (lvlTwoDsply.Contains("_") == false)
                    {
                        beatLvlTwo = true;
                    }
                    if (lvlTwoWord.Contains(lTwoInput) == false)
                    {
                        lvlTwoWrongAttempts++;
                        Console.WriteLine($"Incorrect!");
                    }
                    Console.WriteLine("Please press 'Spacebar' to try again.");
                    bool spacebar = Console.ReadKey().Key == ConsoleKey.Spacebar;
                    Console.Clear();
                }

                if (beatLvlTwo)
                {
                    Console.WriteLine("Congratulations! you beat level two!");
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                }


                Console.WriteLine("Would you like to play again y/n?");
                string lTwouserAnswer = Console.ReadLine();
                Console.Clear();

                //LevelThree----------------------------------------------------------------------------------------------------- 

                Random rndLvlThree = new Random();

                string lvlThreeWord;
                string lThreeInput;

                bool beatLvlThree = false;

                List<string> levelThreeWords = new List<string>(); //List of words for level one difficulty              
                levelThreeWords.Add("acceleration");
                levelThreeWords.Add("backwoodsman");
                levelThreeWords.Add("cantankerous");
                levelThreeWords.Add("decomposable");
                levelThreeWords.Add("egyptologist");
                levelThreeWords.Add("malcontented");
                levelThreeWords.Add("Gentrification");
                levelThreeWords.Add("Infrastructure");
                levelThreeWords.Add("Methamphetamine");
                levelThreeWords.Add("Bioluminescence");

                lvlThreeWord = levelThreeWords[rndLvlThree.Next(levelThreeWords.Count)]; //Randomly selected word from level one list

                int lvlThreeAllowedAttempts = 10;
                int lvlThreeWrongAttempts = 0;
                int lvlThreeRemAttempts = 0;
                int lvlThreeRemLetters = 0;

                List<string> lvlThreeDsply = new List<string>(lvlThreeWord.Length); //hangman blank spaces                
                for (int i = 0; i < lvlThreeWord.Length; i++)
                {
                    lvlThreeDsply.Add("_");
                }

                while (beatLvlThree == false && lvlThreeWrongAttempts <= lvlThreeAllowedAttempts)
                {

                    lvlThreeRemAttempts = lvlThreeAllowedAttempts - lvlThreeWrongAttempts;

                    Console.WriteLine("  Welcome to Hang Man! Level Three \n\n**Hard Difficulty** \n");
                    Console.WriteLine($"Please choose a letter, you have {lvlThreeRemAttempts} guesses.\n");

                    foreach (string letter in lvlThreeDsply)//writes letters in display
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();

                    lThreeInput = Console.ReadLine().ToLower();//gets user input

                    if (lvlThreeWord.Contains(lThreeInput))//checks if letter is in random word
                    {

                        char chlThreeInput = lThreeInput[0];

                        for (int i = 0; i < lvlThreeWord.Length; i++)//changes _ to input char, if there are no more _ the game is won
                        {
                            if (lvlThreeWord[i].Equals(chlThreeInput))
                            {
                                lvlThreeDsply[i] = lThreeInput;
                            }
                        }
                        Console.WriteLine($"Correct!!");
                    }
                    if (lvlThreeDsply.Contains("_") == false)
                    {
                        beatLvlThree = true;
                    }
                    if (lvlThreeWord.Contains(lThreeInput) == false)
                    {
                        lvlThreeWrongAttempts++;
                        Console.WriteLine($"Incorrect!");
                    }
                    Console.WriteLine("Please press 'Spacebar' to try again.");
                    bool spacebar = Console.ReadKey().Key == ConsoleKey.Spacebar;
                    Console.Clear();
                }

                if (beatLvlThree)
                {
                    Console.WriteLine("Congratulations! You Win!");
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
