using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1._2
{
    class Program
    {
        public static bool F1(int x)
        {
            if (x <= 1) return false;
            for(int i=2; i<x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int sum = 0;
            for(int i=0; i<n; i++)
            {
                if (F1(a[i]) == true)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
            for(int i=0; i<n; i++)
            {
                if(F1(a[i])==true)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}
