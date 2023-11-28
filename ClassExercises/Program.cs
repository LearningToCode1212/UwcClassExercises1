namespace ClassExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6 };
            bool checknumbers = OddNumbers.CheckOddNumbers(numbers);
            if (checknumbers)
            {
                Console.WriteLine("contains odd");
            } else
            {
                Console.WriteLine("contains even");
            }

            string letters = "Hello World";
            string RemoveAllVowels = Vowels.RemoveVowels(letters);
            Console.WriteLine(RemoveAllVowels);

            int[] list = { -1, 2, 4, 6, 9 };
            string postiveNegative = PostiveNegative.CountPostiveNegative(list);
            Console.WriteLine(postiveNegative);
        }
    }
}
