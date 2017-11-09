using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Age = 22;
            stu.Name = "Nisar Ahmed";
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Age);
            Console.ReadLine();
        }
    }

    struct Student
    {
       public int Age;
        public string Name;
    }
}
