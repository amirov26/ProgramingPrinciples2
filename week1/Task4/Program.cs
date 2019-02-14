﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n - is the size of our two-dimensional array(n*n)
            int[,] a = new int[n, n];
            for(int i = 0; i<n; i++) // cycle for rows
            {
                for(int j=0; j<i+1; j++) // cycle for columns
                {
                    Console.Write("[*]");
                }
                Console.WriteLine(); // new line(row)
            }
        }
    }
}
