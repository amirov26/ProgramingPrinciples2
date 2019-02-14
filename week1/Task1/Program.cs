using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool F1(int x)
        {
            if (x <= 1) return false; // prime number is a whole number greater than 1
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false; // by definition of prime numbers: they can only be divided by themselves and 1
            }
            return true; // if the above conditions are not met, then it is a prime number
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n - size of the array
            int[] a = new int[n];
            string[] arr = Console.ReadLine().Split(); // filling array and splitting the string
            for (int i = 0; i < arr.Length; i++)
            {
                a[i] = int.Parse(arr[i]); // converting elements of array from string to int
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true)
                {
                    sum++; 
                }
            }
            Console.WriteLine(sum); // outputting the total number of prime numbers 
            for (int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true)
                {
                    Console.Write(a[i] + " "); // outputting all prime numbers from the array
                }
            }
        }
    }
}
