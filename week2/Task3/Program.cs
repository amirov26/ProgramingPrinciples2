using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Level(int level)
        {
            for(int i=0; i<level; i++)
            {
                Console.Write("   ");
            }
        }
        public static void Tree(DirectoryInfo path, int level)
        {
            foreach(FileInfo f in path.GetFiles())
            {
                Level(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in path.GetDirectories())
            {
                Level(level);
                Console.WriteLine(d.Name);
                Tree(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@"C:/Users/agent/Desktop/3");
            Tree(path, 0);
        }
    }
}
