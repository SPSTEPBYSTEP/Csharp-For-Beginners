using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple array

            //int[] myarray = { 0, 1, 2, 3, 4, 5 };
            //Console.WriteLine(myarray[3]);
            //Console.ReadLine();
            #endregion

            #region get values from user
            int[] myarray = new int[5];

            myarray[0] = 1;
            myarray[1] = 2;
            myarray[2] = 3;
            Console.WriteLine(myarray[2]);
            Console.ReadLine();
            #endregion

        }
    }
}
