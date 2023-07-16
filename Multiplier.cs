using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class Multiplier
    {
        public static int Multiply(int num) => num * (num % 2 == 0 ? 8 : 9);
        
    }
}
