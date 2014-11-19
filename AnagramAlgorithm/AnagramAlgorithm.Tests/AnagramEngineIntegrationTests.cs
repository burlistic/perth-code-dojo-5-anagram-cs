using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmEngine;
using Xunit;
using Xunit.Sdk;

namespace AnagramAlgorithm.Tests
{

    public class AnagramEngineIntegrationTests
    {
        [Fact]
        public void Find()
        {
            IEnumerable<string> words = WordListLoader.Load(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\simpewordlist.txt");

            List<string> matches = AnagramEngine.Find("caticanibla", words.ToList());

            Console.Write("caticanibla" + " - ");

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }

            Console.Write("/r");
        }

    }

}
