using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class SortArray
    {
        public static int[] ArraySorter(int[] array)
        {
            int[] nums = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = nums[0];
                    nums = nums.Skip(1).ToArray();
                }

            }
            


            return array;
        }
    }
}
