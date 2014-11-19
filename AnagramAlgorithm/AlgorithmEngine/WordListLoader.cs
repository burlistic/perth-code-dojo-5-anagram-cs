using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmEngine
{
    public class WordListLoader
    {
        public static IEnumerable<string> Load(string filePath)
        {
            // Refactor to use?

            //AppDomain.CurrentDomain.BaseDirectory;
            //"D:\\Projects\\perth-code-dojo-5-anagram-algorithm\\AnagramAlgorithm\\AnagramAlgorithm.Tests\\bin\\Debug"

            using (var reader = File.OpenText(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
