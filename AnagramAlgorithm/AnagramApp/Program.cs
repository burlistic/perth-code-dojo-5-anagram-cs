using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AlgorithmEngine;

namespace AnagramApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Refactoring filtering down

            IEnumerable<string> words = WordListLoader.Load(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\wordlist.txt")
                .Where(w => w.Length >= 3 &&
                Regex.IsMatch(w.ToString(), @"^[a-z]+$"));

            foreach (var word in words)
            {
         
                Console.Write(word + " - ");

                List<string> matches = AnagramEngine.Find(word, words.ToList());

                foreach (var match in matches)
                {
                    Console.Write(match + " ");
                }
                Console.WriteLine();    
            }

            stopwatch.Stop();

            Console.WriteLine("Time to completion -" + stopwatch.ElapsedMilliseconds);

            Console.ReadLine();




        }
    }
}
