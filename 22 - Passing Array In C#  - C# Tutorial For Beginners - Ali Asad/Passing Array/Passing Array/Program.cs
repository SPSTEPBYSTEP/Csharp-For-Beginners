using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Array
{
    class Program
    {
        #region value of array can't in in for each loop

        //static void Main(string[] args)
        //{
        //    int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    ArrayMethod(myarray);
        //    Console.ReadLine();
        //}

        //static void ArrayMethod(int[] values)
        //{
        //    foreach (var item in values)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
        #endregion

        #region value of array can be change by using each loop
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ArrayMethod(myarray);

            //foreach (var item in myarray)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }

        static void ArrayMethod(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] += 2;
            }

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
}
