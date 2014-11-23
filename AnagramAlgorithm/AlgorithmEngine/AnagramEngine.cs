using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmEngine
{
    public class AnagramEngine
    {
        public static List<string> Find(string seedWord, List<string> wordList)
        {
            var matchedWords = new List<string>();
            
            foreach (var word in wordList)
            {
                var wordLower = word.ToLower();
                var seedWordCopy = seedWord.ToLower();

                var match = true;

                var wordChars = wordLower.ToCharArray();

                foreach (var wordChar in wordChars)
                {

                    //ignore special characters
                    if (Regex.IsMatch(wordChar.ToString(), @"^[a-zA-Z]+$"))
                    {
                        if (!seedWordCopy.Contains(wordChar))
                        {
                            match = false;
                            //break;
                        }
                        else
                        {
                            seedWordCopy = seedWordCopy.Remove(seedWordCopy.IndexOf(wordChar), 1);
                        }
                    }

                }

                if (match)
                {
                    matchedWords.Add(word);
                }

            }

            return matchedWords;

        }
    }
}
