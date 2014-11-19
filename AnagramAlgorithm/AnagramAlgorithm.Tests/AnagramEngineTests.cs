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

    public class AnagramEngineTests
    {
        [Fact]
        public void Find_Simple_Anagram()
        {
            List<string> matches = AnagramEngine.Find("cat", new List<string> {"at", " bla", "rah", "ct"});

            Assert.Equal(2, matches.Count);
        }

        [Fact]
        public void Find_Simple_Anagram_Uppercase()
        {
            List<string> matches = AnagramEngine.Find("CAT", new List<string> { "at", " bla", "rah", "ct" });

            Assert.Equal(2, matches.Count);
        }

        [Fact]
        public void Find_Simple_Anagram_Allowed_Punctuation()
        {
            List<string> matches = AnagramEngine.Find("cat's", new List<string> { "at", " bla", "rah", "ct", "cts", "ca's" });

            Assert.Equal(4, matches.Count);
        }
    }

}
