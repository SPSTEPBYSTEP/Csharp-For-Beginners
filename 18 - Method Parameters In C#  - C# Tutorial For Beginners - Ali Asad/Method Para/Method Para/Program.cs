using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Para
{
    class Program
    {
        #region Method with one parameter

        // static void Main(string[] args)
        // {
        //     mymethod(5);
        //     Console.ReadLine();
        // }

        //static void mymethod(int count)
        // {
        //     for (int i = 0; i < count; i++)
        //     {
        //         Console.WriteLine("Nisar Ahmed");
        //     }
        // }
        #endregion

        #region Method with two parameter

        //static void Main(string[] args)
        //{
        //    mymethod(5,"Nisar Ahmed");
        //    Console.ReadLine();
        //}

        //static void mymethod(int count, string message)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(message);
        //    }
        //}
        #endregion

        #region how to exchange the parameter
        //static void Main(string[] args)
        //{
        //    mymethod(message:"Nisar Ahmed",count:45);
        //    Console.ReadLine();
        //}

        //static void mymethod(int count, string message)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(message);
        //    }
        //}
        #endregion

        #region get values from user
        static void Main(string[] args)
        {
            Console.Write("Please enter your message :");
            string mes = Console.ReadLine();

            Console.Write("please enter the value of count");
            int cou =int.Parse( Console.ReadLine());

            mymethod(cou,mes);
            Console.ReadLine();
        }

        static void mymethod(int count, string message)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
        #endregion
    }
}
