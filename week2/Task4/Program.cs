using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/agent/Desktop/ProgramingPrinciples2/week2/Task4";
            DirectoryInfo directory = new DirectoryInfo(path);
            string path2 = directory.Parent.FullName;
            FileStream fs = File.Create(path + "/Amirov.txt");
            fs.Close();
            File.Copy(path + "/Amirov.txt", path2 + "/Amirov.txt");
            File.Delete(path + "/Amirov.txt");
        }
    }
}
