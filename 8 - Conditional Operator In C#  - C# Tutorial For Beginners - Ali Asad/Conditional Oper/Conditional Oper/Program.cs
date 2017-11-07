using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple if else
            //string message;
            //if (2>4)
            //{
            //    message = "2 is less then 4";
            //}
            //else
            //{
            //    message = "2 is grater then 4";
            //}

            //Console.WriteLine(message);
            #endregion

            #region conditional operater

            string message = (2 > 4) ? "2 is grater then 4" : "2 is less then 4";
            Console.WriteLine(message);
            Console.ReadLine();

            #endregion
        }
    }
}
