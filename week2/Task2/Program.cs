using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            string s = System.IO.File.ReadAllText(@"C:\Users\agent\Desktop\input.txt");
            int[] a = new int[s.Length];
            a = s.Split().Select(int.Parse).ToArray();
            List<int> v = new List<int>();
            for(int i=0; i<a.Length;i++)
            {
                if (F1(a[i]) == true) v.Add(a[i]);
            }
            var result = String.Join(" ", v.ToArray());
            System.IO.File.WriteAllText(@"C:\Users\agent\Desktop\output.txt", result);
        }
    }
}
