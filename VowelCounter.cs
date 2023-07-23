using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class VowelCounter
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
           
        }
    }
}
