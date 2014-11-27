using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramAppMarkFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            File.ReadAllLines(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\wordlist.txt")
            .GroupBy(w => String.Concat(w.OrderBy(c => c)))
            .Where(g => g.Count() > 1)
            .ToList().ForEach(g => Console.WriteLine(String.Join(" ", g)));

            Console.ReadLine();
        }
    }
}
