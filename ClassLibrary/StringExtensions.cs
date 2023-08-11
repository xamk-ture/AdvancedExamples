using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StringExtensions
    {
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
