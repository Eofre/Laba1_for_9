using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Logic
    {
        public static string Min(int[] numbers)
        {
            int min = int.MaxValue;


            for (int i = 0; i < numbers.Length; i++)
            {

                if (min > numbers[i])
                {

                    min = numbers[i];

                }
            }
            int min2 = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (min2 > numbers[i] & numbers[i] != min)
                {
                    min2 = numbers[i];
                }
            }
            var message = "Наименьшие числа равны " + min + " и " + min2;
            return message;
        }
        public static string Max(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            int max2 = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (max2 < numbers[i] & numbers[i] != max)
                {
                    max2 = numbers[i];
                }
            }
            var message2 = "Наибольшие числа равны " + max + " и " + max2;
            return message2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 0, 67 };
            var message = Logic.Min(numbers);
            var message2 = Logic.Max(numbers);
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.ReadKey();
        }
    }
}
