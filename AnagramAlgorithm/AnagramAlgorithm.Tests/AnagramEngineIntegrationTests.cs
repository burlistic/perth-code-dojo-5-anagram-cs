using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AlgorithmEngine;
using Xunit;
using Xunit.Sdk;

namespace AnagramAlgorithm.Tests
{

    public class AnagramEngineIntegrationTests
    {
        //[Fact]
        //public void Find()
        //{
        //    IEnumerable<string> words = WordListLoader.Load(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\simpewordlist.txt");

        //    List<string> matches = AnagramEngine.Find("caticanibla", words.ToList());

        //    Console.Write("caticanibla" + " - ");

        //    foreach (var match in matches)
        //    {
        //        Console.Write(match + " ");
        //    }

        //    Console.Write("/r");
        //}


        [Fact]
        public void Find()
        {
            IEnumerable<string> words = WordListLoader.Load(
                @"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\wordlist.txt")
                .Where(w => w.Length >= 3 &&
                Regex.IsMatch(w.ToString(), @"^[a-z]+$"));

            var sw = new Stopwatch();
            sw.Reset();
            sw.Start();

            TestTimer tt = new TestTimer();
            tt.Start();

            List<string> matches = AnagramEngine.Find("webster", words.ToList());

            Console.Write("webster" + " - ");

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }

            tt.Start();
            Console.WriteLine(tt.ElapsedMilliseconds);

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //600 - 700 list

            //450 - 550

        }

    }

}
