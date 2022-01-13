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
            int remAttempts = 0;
            int score = 0;
            string lvlOne = "one";

            while (playGameAgain)
            {
                string word;
                string input;
                bool beatLvl = false;

                List<string> levelOneWords = new List<string>();               
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

                word = GetRndWord(levelOneWords);

                int allowedAttempts = 10;
                int wrongAttempts = 0;

                List<string> underScores = GenerateUnderScores(word.Length);

                while (beatLvl == false && wrongAttempts <= allowedAttempts)
                {
                    //Console.WriteLine(lvlOneWord);//for testing only!!!
                    remAttempts = allowedAttempts - wrongAttempts;

                    UIMethods.WelcomeMessage(remAttempts, lvlOne);

                    WriteLetters(underScores);

                    input = UIMethods.GetInput();                   

                    if (word.Contains(input))//checks if letter is in random word
                    {
                        char chInput = input[0];

                        for (int i = 0; i < word.Length; i++)//changes _ to input char, if there are no more _ the game is won
                        {
                            if (word[i].Equals(chInput))
                            {
                                underScores[i] = input;
                            }
                        }                        
                        UIMethods.Correct();
                    }
                    if (underScores.Contains("_") == false)
                    {
                        beatLvl = true;
                    }
                    if (word.Contains(input) == false)
                    {
                        wrongAttempts++;
                        UIMethods.Incorrect();
                    }                   
                    UIMethods.TryAgain();
                }

                if (beatLvl)
                {
                    score = remAttempts;                   
                    UIMethods.BeatLvlMessage(lvlOne, score);
                }
                else
                {
                    UIMethods.GameOver();
                    string userAnswer = UIMethods.GetInput();
                    if (userAnswer != yesString)
                    {
                        System.Environment.Exit(0);
                    }
                    playGameAgain = userAnswer == yesString;
                    
                }

            }
        }

        /// <summary>
        /// Writes letters in display
        /// </summary>
        /// <param name="underscores"></param>
        static void WriteLetters (List<string> underscores)
        {
            foreach (string letter in underscores)//writes letters in display
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }       
        /// <summary>
        /// Generates underscores based on the number of letters in the random word
        /// </summary>
        /// <param name="wordLength"></param>
        /// <returns>a list of underscores based on rnd word length</returns>
        static List<string> GenerateUnderScores (int wordLength)
        {
            List<string> underScores = new List<string>(wordLength); //hangman blank spaces                
            for (int i = 0; i < wordLength; i++)
            {
                underScores.Add("_");
            }
            return underScores;
        }
        /// <summary>
        ///  method that returns a ranom word from a list of words
        /// </summary>
        /// <param name="wordList">the list to pick a word from</param>
        /// <returns>a random word of that list</returns>
        static string GetRndWord (List<string> wordList)
        {
            Random random = new Random();
            string rndWord = wordList[random.Next(wordList.Count)];
            return rndWord;
        }

        



    }
}
