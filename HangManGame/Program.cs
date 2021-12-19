using System;
using System.Collections.Generic;
using System.Linq;

namespace HangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGameAgain = true;
            string yesString = "y";
            int lvlOneRemAttempts = 0;
            int lvlTwoRemAttempts = 0;
            int lvlThreeRemAttempts = 0;
            int score = 0;

            while (playGameAgain)
            {

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

                List<string> lvlOneDsply = new List<string>(lvlOneWord.Length); //hangman blank spaces                
                for (int i = 0; i < lvlOneWord.Length; i++)
                {
                    lvlOneDsply.Add("_");
                }

                while (beatLvlOne == false && lvlOneWrongAttempts <= lvlOneAllowedAttempts)
                {
                    //Console.WriteLine(lvlOneWord);//for testing only!!!
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
                    Console.WriteLine("Please press 'Enter' to try again.");
                    bool enter = Console.ReadKey().Key == ConsoleKey.Enter;
                    Console.Clear();
                }

                if (beatLvlOne)
                {
                    score = lvlOneRemAttempts;
                    Console.WriteLine($"Congratulations! you beat level one! your score is {score} points");
                    Console.WriteLine("Please press 'Spacebar' continue.");
                    bool spaceBar = Console.ReadKey().Key == ConsoleKey.Spacebar;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("Would you like to play again y/n?");
                    string lOneuserAnswer = Console.ReadLine().ToLower();
                    if (lOneuserAnswer != yesString)
                    {
                        System.Environment.Exit(0);
                    }
                    playGameAgain = lOneuserAnswer == yesString;
                    Console.Clear();
                }

            }
        }
        static string LetterCheck(string wordCheck, string input, List<string> display) //method to compare input to random word (non Functional)
        {
            if (wordCheck.Contains(input))
            {
                char chInput = input[0];

                for (int i = 0; i < wordCheck.Length; i++)
                {
                    if (wordCheck[i].Equals(chInput))
                    {
                        display[i] = input;
                    }
                }
                string correct = Console.WriteLine($"Correct!!");
                return display + correct;

            }
        }



    }
}
