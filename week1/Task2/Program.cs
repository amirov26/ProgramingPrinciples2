using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
            string name;
            string id;      // global variables
            int year;

            public Student(string n, string i) // constructor with two parametres
            {
                name = n;
                id = i;
            } 

            public void GetInfo()
            {
                year = 2018;
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(name + " ");  // outputting name
                    Console.Write(id + " ");   // outputting id
                    Console.WriteLine(year);  // outputting year
                    year++;
                }
            }

        static void Main(string[] args)
        {
            Student s = new Student("Dauren", "18BD110809"); // call for constructor
            s.GetInfo();
        }
    }
} 
