using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmEngine;

namespace AnagramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");

            var word = Console.ReadLine();

            IEnumerable<string> words = WordListLoader.Load(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\wordlist.txt")
                .Where(w => w.Length > 3);

            Console.Write(word + " - ");

            List<string> matches = AnagramEngine.Find(word, words.ToList());

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();

            Console.ReadLine();




        }
    }
}
