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

    // FileReader ??

    // Giant dictionay output

    // Input - word, dictionay // Output, matches
    
    
    public class AnagramEngineTests
    {
        [Fact]
        public void FindASimpleAnagram()
        {
            List<string> matches = AnagramEngine.Find("cat", new List<string> {"at", " bla", "rah", "ct"}); // array?

            Assert.Equal(2, matches.Count);
        }
    }

    // test casing
}
