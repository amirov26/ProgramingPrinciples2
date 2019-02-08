using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool F1(string s, int n)
        {
            for(int i=0; i<s.Length/2; i++)
            {
                if (s[i] == s[n-i-1]) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C: \Users\agent\Desktop\palindrome.txt");
            int n = s.Length;
            if (F1(s,n) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
