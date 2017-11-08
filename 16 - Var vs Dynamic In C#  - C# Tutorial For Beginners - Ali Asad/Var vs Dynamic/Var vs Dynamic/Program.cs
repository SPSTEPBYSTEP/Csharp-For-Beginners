using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_vs_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region var as a int data type
            //var age = 22;
            //Console.WriteLine(age.GetType());
            //Console.ReadLine();
            #endregion

            #region var as string data type
            //var name = "Nisar Ahmed";
            //Console.WriteLine(name.GetType());
            //Console.WriteLine(name.ToUpper());
            //Console.ReadLine();
            #endregion

            #region Dynamic
            dynamic Age=22;
            Console.WriteLine(Age);
            Console.WriteLine(Age.GetType());
           

            Age = "Nisar Ahmed";
            Console.WriteLine(Age);
            Console.WriteLine(Age.GetType());
            Console.ReadLine();
            #endregion
        }
    }
}
