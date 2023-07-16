using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class DuplicateCount
    {
        public static int DuplicateCounter(string str)
        {
            //int duplicateCount = 0;
            //var duplicates = new List<char>();
            //string lowered = str.ToLower();

            //foreach (var c in lowered)
            //{
            //    if (lowered.IndexOf(c) != lowered.LastIndexOf(c)
            //        && !duplicates.Contains(c))
            //    {
            //        duplicates.Add(c);
            //    }
            //}

            //foreach (var c in duplicates)
            //{
            //    duplicateCount++;
            //}

            //return duplicateCount;

            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}
