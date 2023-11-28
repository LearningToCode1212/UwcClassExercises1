using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class OddNumbers
    {
        public static bool CheckOddNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (number % 2 > 0 )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
