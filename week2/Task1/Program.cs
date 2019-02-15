using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            StreamReader sr = new StreamReader(@"C: \Users\agent\Desktop\palindrome.txt");
            string s = sr.ReadToEnd();
            int n = s.Count();
            if (F1(s,n) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            sr.Close();
        }
    }
}
