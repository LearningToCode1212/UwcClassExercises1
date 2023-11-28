using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class Vowels
    {
        private static bool IsAVowel(char letter) 
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < vowels.Length; i++)
            { 
                if (vowels[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }
        public static string RemoveVowels(string letters)
        {
            string returnString = "";
            for (int j = 0; j < letters.Length; j++) 
            {
                char letter = letters[j];
                bool vowel = IsAVowel(letter);
                if (!vowel)
                {
                    returnString += letter;
                }
            }
            return returnString;
        }
    }
}
