using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_in_Stru
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Nisar Ahmed";
            std.Age = 22;
            std.Display();
        }
    }

    struct Student
    {
       public int Age;
       public string Name;

        public void Display()
        {
            Console.WriteLine("Age is {0}",Age);
            Console.WriteLine("Name is {0}",Name);
            Console.ReadLine();
        }

    }
}
