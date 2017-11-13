using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Para
{
    class Program
    {
        static void Main(string[] args)
        {
            optional();
            Console.ReadLine();
        }   

        static void optional(string name="Nisar Ahmed")
        {
            Console.WriteLine(name);
        }
    }
}
