using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kata
    {
         //Three 1's => 1000 points
         //Three 6's =>  600 points
         //Three 5's =>  500 points
         //Three 4's =>  400 points
         //Three 3's =>  300 points
         //Three 2's =>  200 points
         //One   1   =>  100 points
         //One   5   =>   50 point

        public static int Score(int[] ary)
        {
            var group = ary.GroupBy(c => c);

            var count = 0;
            foreach (var item in group)
            {
                if (item.Count() > 3)
                {
                    count += item.Key * 100;
                }

                if (item.Count() > 3 && item.Key == 1)
                {
                    count += item.Key * 1000;
                }

                if (item.Count() % 3 > 0 && item.Key == 1)
                {
                    count += item.Key * 100;
                }

                if (item.Count() % 3 > 0 && item.Key == 5)
                {
                    count += item.Key * 10;
                }
            }

            return count;
        }
    }
}
