using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleT8.Models
{
    public class Student
    {
        public string Name;
        public string Major;
        public float Gpa;
        public void print()
        {
            Console.WriteLine("Name: {0}, Major: {1}, Gpa: {2}", Name, Major, Gpa);
        }
    }
}
