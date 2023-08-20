namespace ClassLibrary
{
    public class WordCounter
    {

        /// <summary>
        /// Counts the number of words in a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int? CountWords(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var words = input.Split(' ');
            var wordCount = words.Length;
            return wordCount;
        }
    }
}