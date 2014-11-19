using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                var match = true;

                var seedChars = word.ToCharArray();

                foreach (var seedChar in seedChars)
                {

                    if (!seedWord.ToLower().Contains(seedChar))
                    {
                        match = false;
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
