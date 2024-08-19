using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCleaner
{
    public class LettersCleaner
    {
        public static string Cleaner(string input)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97 && input[i] <= 122)
                {
                    builder.Append(input[i]);
                }
           }
           return builder.ToString();

        }
    }
}
