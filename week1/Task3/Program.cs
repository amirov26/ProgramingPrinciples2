using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n - size of the array
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(); // filling array and splitting the string
            for (int i = 0; i<n; i++)
            {
                a[i] = int.Parse(s[i]); // converting elements of array from string to int
            }
            int z = n * 2;
            int[] b = new int[z]; //in second array we double previous size and call it z
            for (int i = 0; i<n; i++)
            {
                b[2*i] = a[i];
                b[2 * i + 1] = a[i]; // we give the formula of array, where every element is repeated
            }
            for(int i = 0; i<z; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}
