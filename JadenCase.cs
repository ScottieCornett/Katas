using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {

            return string.Join(" ", phrase.Split(' ').Select(str => char.ToUpper(str[0]) + str.Substring(1)));

           
        }
    }
}
