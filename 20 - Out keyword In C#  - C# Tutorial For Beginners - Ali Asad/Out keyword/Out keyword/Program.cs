using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            passbyout(out value);
            Console.WriteLine("my value  {0}",value);
            Console.ReadLine();

        }

        static void passbyout(out int myvalue)
        {
            myvalue = 10;
            Console.WriteLine("my value  {0}",myvalue);
        }
    }
}
