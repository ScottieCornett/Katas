using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class MathCheck
    {
        public static int AreaOrPerimeter(int l, int w)
        {
            return l == w ? l * w : 2 * l + 2 * w;
            
        }
    }
}
