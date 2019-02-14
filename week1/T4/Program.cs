using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<i+1; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
