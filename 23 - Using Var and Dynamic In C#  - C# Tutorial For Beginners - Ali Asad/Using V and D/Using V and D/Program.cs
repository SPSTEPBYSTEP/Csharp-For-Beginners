using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_V_and_D
{
    class Program
    {
        static void Main(string[] args)
        {
            demo(55);
            Console.ReadLine();
        }
        static void demo(dynamic data)
        {
            Console.WriteLine(data);
        }
    }
}
