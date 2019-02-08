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
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split();
            for(int i = 0; i<n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int z = n * 2;
            int[] b = new int[z];
            for(int i = 0; i<n; i++)
            {
                b[2*i] = a[i];
                b[2 * i + 1] = a[i];
            }
            for(int i = 0; i<z; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}
