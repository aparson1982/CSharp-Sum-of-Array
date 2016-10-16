using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers?");
            int total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minimum Number: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximimum Number: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[total];

            Random randNum = new Random();


            Console.WriteLine("\n Random Numbers: ");

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(min, max);
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("The sum is:  " + sumArray(numbers));

            //Console.WriteLine(sumArray(numbers));

            System.Threading.Thread.Sleep(100000);
            
        }

       
        private static int sumArray(int[] numbers)
        {
            int totalSum = 0;

            foreach (int number in numbers)
            {
                totalSum += number;
            }

            return totalSum;
        }
    }
}
