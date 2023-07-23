using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class PositiveChecker
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            return new int[] { a, b, c }.Count(x => x > 0) == 2;
            
        }
    }
}
