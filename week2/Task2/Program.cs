using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            StreamReader sr = new StreamReader(@"C:\Users\agent\Desktop\input.txt");
            string[] s = sr.ReadToEnd().Split();
            int n = s.Count();
            int[] a = new int[n];
            List<int> v = new List<int>();
            for(int i=0; i<a.Length;i++)
            {
                a[i] = int.Parse(s[i]);
                if (F1(a[i]) == true) v.Add(a[i]);
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\agent\Desktop\output.txt");
            for(int i=0; i<v.Count(); i++)
            {
                sw.Write(v[i] + " ");
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
