using System.Linq;

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
            var group = ary.GroupBy(c => c)
                .Select(c => Calculate(c.Key, c.Count()))
                .Sum();

            return group;
        }

        private static int Calculate(int key, int count)
        {
            var num = 0;
            if (count >= 3 && key != 1)
            {
                num += key * 100;
            }
            if (key == 1)
            {
                num += (count / 3) * 1000 + count % 3 * 100;
            }

            if (count % 3 > 0 && key == 5)
            {
                num += (count / 3) * 500 + count % 3 * 50;
            }
            return num;
        }
    }
}