using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class Concatonator
    {
        public static string Concatonate(string sentence)
        {
            const int MaxLength = 20;
            if (sentence.Length < MaxLength)
            {
                return sentence;
            }
            else
            {
                var words = sentence.Split(' ');
                int totalCharacters = 0;
                List<string> summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > MaxLength)
                    {
                        break;
                    }
                }

                return string.Join(" ", summaryWords) + " ... ";
            }

           

        }
    }
}
