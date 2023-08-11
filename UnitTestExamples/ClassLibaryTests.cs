using ClassLibrary;

namespace UnitTestExamples
{
    public class ClassLibaryTests
    {
        [Fact]
        public void WordCounterTest()
        {
            //arrange
            var wordCounter = new WordCounter();

            //act
            var wordCount = wordCounter.CountWords("Hello, World!");

            //assert
            Assert.Equal(2, wordCount);
        }

        [Fact]
        public void WordCounterNullTest()
        {
            //arrange
            var wordCounter = new WordCounter();

            //act
            var wordCount = wordCounter.CountWords("");

            //assert
            Assert.Null(wordCount);
        }

        [Theory]
        [InlineData("Hello, World!", 2)]
        [InlineData(null, null)]
        public void WordCounterTheoryTest(string input, int? expected)
        {
            //arrange
            var wordCounter = new WordCounter();

            //act
            var wordCount = wordCounter.CountWords(input);

            //assert
            Assert.Equal(expected, wordCount);
        }

        [Theory]
        [InlineData("Hello, World!", 2)]
        [InlineData(null, null)]
        public void ExtensionWordCounterTest(string input, int? expected)
        {
            //act
            var wordCount = input.CountWords(); 

            //assert
            Assert.Equal(expected, wordCount);
        }
    }
}