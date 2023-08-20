using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Tämä on esimerkki extension-methodista. Lisätietoa https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        /// Counts the number of words in a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int? CountWords(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var words = input.Split(' ');
            var wordCount = words.Length;
            return wordCount;
        }
    }
}
