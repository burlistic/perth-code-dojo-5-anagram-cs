using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmEngine;
using Xunit;
using Xunit.Sdk;

namespace AnagramAlgorithm.Tests
{

    public class ListReaderIntegrationTests
    {
        [Fact]
        public void LoadSimpleWordList()
        {
            IEnumerable<string> words = WordListLoader.Load(@"D:\Projects\perth-code-dojo-5-anagram-algorithm\AnagramAlgorithm\AlgorithmEngine\App_Data\simpewordlist.txt"); // relative ?

            Assert.Equal(5, words.ToList().Count);
        }

    }
}
