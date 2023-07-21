using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Katas
{
    public class Backwords
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    char[] letters = words[i].ToCharArray();
                    Array.Reverse(letters);
                    words[i] = new string(letters);
                }
            }

            return string.Join(" ", words);
        }

    }
}
