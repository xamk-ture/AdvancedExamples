using ClassLibrary;

namespace UnitTestExamples
{
    public class ClassLibraryTests
    {
        //WordCounterTest() ja WordCounterNullTest() testit ovat esimerkkejä, jos testit tehätisiin ilman InlineDataa
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

        //Koska WordCounterTheoryTest on parametrisoitu, voidaan hyödyntää InLindeData-attributea ja mitään erillisiä testejä eri skenaarioille ei tarvita
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

        //Testataan extension methodia
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