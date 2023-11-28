using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class PostiveNegative
    {
        public static string CountPostiveNegative(int[] numbers)
        {
            int postive = 0;
            int negative = 0;
            // string result = $"postive: {postive} & negative: {negative}";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    postive++;
                } else
                {
                    negative++;
                }
            }
            string result = $"postive: {postive} & negative: {negative}";
            return result;
        }
    }
}
