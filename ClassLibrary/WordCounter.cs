namespace ClassLibrary
{
    public class WordCounter
    {
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