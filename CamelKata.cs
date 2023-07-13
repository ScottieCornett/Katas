using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class CamelKata
    {
        public static string GetCamelCase(string str)
        {
            int i = 0;

            while (true)
            {
                i = 0;

                while (i < str.Length)
                {
                    if (str[i] == '-' || str[i] == '_')
                    {
                        char newChar = char.ToUpper(str[i + 1]);
                        str = str.Substring(0, i) + newChar + str.Substring(i + 2);
                        break;
                    }

                    i++;
                }
                if(i == str.Length)
                {
                    break;
                }
            }
            return str;
        }
    }
}
