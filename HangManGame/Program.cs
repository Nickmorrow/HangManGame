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
            int lvlsBeaten = 0;

            while (playGameAgain)
            {
                if (lvlsBeaten == 3)
                {
                    lvlsBeaten = 0;
                    score = 0;
                }
                
                string level = GetLevel(lvlsBeaten);
                string difficulty = GetDifficulty(lvlsBeaten);
                string word = "";
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

                List<string> levelTwoWords = new List<string>();
                levelTwoWords.Add("business");
                levelTwoWords.Add("elephant");
                levelTwoWords.Add("sandwich");
                levelTwoWords.Add("violence");
                levelTwoWords.Add("november");
                levelTwoWords.Add("habaneros");
                levelTwoWords.Add("macadamia");
                levelTwoWords.Add("abandoned");
                levelTwoWords.Add("government");
                levelTwoWords.Add("restaurant");

                List<string> levelThreeWords = new List<string>();
                levelThreeWords.Add("acceleration");
                levelThreeWords.Add("backwoodsman");
                levelThreeWords.Add("cantankerous");
                levelThreeWords.Add("decomposable");
                levelThreeWords.Add("egyptologist");
                levelThreeWords.Add("malcontented");
                levelThreeWords.Add("gentrification");
                levelThreeWords.Add("infrastructure");
                levelThreeWords.Add("methamphetamine");
                levelThreeWords.Add("bioluminescence");

                if (lvlsBeaten == 0)
                {
                    word = GetRndWord(levelOneWords);
                }
                if (lvlsBeaten == 1)
                {
                    word = GetRndWord(levelTwoWords);
                }
                if (lvlsBeaten == 2)
                {
                    word = GetRndWord(levelThreeWords);
                }

                int allowedAttempts = 10;
                int wrongAttempts = 0;

                List<string> underScores = GenerateUnderScores(word.Length);

                while (beatLvl == false && wrongAttempts <= allowedAttempts)
                {
                    //Console.WriteLine(word);//for testing only!!!
                    remAttempts = allowedAttempts - wrongAttempts;

                    UIMethods.WelcomeMessage(remAttempts, level, difficulty);

                    WriteLetters(underScores);

                    input = UIMethods.GetInput();

                    if (word.Contains(input))//checks if letter is in random word
                    {
                        char chInput = input[0];

                        for (int i = 0; i < word.Length; i++)//changes _ to input char, if there are no more _ the game is won
                        {
                            if (word[i].Equals(chInput))
                            {
                                underScores[i] = Char.ToString(chInput); 
                            }
                        }
                        UIMethods.Correct();
                    }
                    if (underScores.Contains("_") == false)
                    {
                        beatLvl = true;
                        lvlsBeaten++;
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
                    score = score + remAttempts;

                    if (lvlsBeaten < 3)
                    { 
                        UIMethods.BeatLvlMessage(level, score);
                    }
                    if (lvlsBeaten == 3)
                    {
                        UIMethods.BeatGameMessage(score);
                        string userAnswer = UIMethods.GetInput();
                        if (userAnswer != yesString)
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    UIMethods.Clear();
                }
                else
                {
                    UIMethods.GameOver();
                    string userAnswer = UIMethods.GetInput();
                    if (userAnswer != yesString)
                    {
                        System.Environment.Exit(0);
                    }
                    UIMethods.Clear();
                    playGameAgain = userAnswer == yesString;

                }

            }
        }

        /// <summary>
        /// Writes letters in display
        /// </summary>
        /// <param name="underscores">letters to write</param>
        static void WriteLetters(List<string> underscores)
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
        /// <param name="wordLength">length of the word</param>
        /// <returns>a list of underscores based on rnd word length</returns>
        static List<string> GenerateUnderScores(int wordLength)
        {
            List<string> underScores = new List<string>(wordLength); //hangman blank spaces                
            for (int i = 0; i < wordLength; i++)
            {
                underScores.Add("_");
            }
            return underScores;
        }
        /// <summary>
        ///  method that returns a random word from a list of words
        /// </summary>
        /// <param name="wordList">the list to pick a word from</param>
        /// <returns>a random word of that list</returns>
        static string GetRndWord(List<string> wordList)
        {
            Random random = new Random();
            string rndWord = wordList[random.Next(wordList.Count)];
            return rndWord;
        }
        /// <summary>
        /// Changes the level of game
        /// </summary>
        /// <param name="lvlsBeaten"></param>
        /// <returns>Level of game</returns>
        static string GetLevel(int lvlsBeaten)
        {
            string level = "";

            if (lvlsBeaten == 0)
            {
                level = "one";
            }
            if (lvlsBeaten == 1)
            {
                level = "two";
            }
            if (lvlsBeaten == 2)
            {
                level = "three";
            }
            return level;

        }
        /// <summary>
        /// Changes the difficulty of game
        /// </summary>
        /// <param name="lvlsBeaten"></param>
        /// <returns>Difficulty of game</returns>
        static string GetDifficulty(int lvlsBeaten)
        {
            string difficulty = "";

            if (lvlsBeaten == 0)
            {
                difficulty = "Easy";
            }
            if (lvlsBeaten == 1)
            {
                difficulty = "Intermediate";
            }
            if (lvlsBeaten == 2)
            {
                difficulty = "Brutal";
            }
            return difficulty;

        }






    }
}
