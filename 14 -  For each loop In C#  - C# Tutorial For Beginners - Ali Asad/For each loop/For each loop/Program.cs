using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_each_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in myarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
