using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_method
{
    class Program
    {
        #region for int data type
        //static void Main(string[] args)
        //{

        //    Console.Write("enter the value of a : ");
        //    int x =int.Parse( Console.ReadLine());
        //    Console.Write("enter the value of b : ");
        //    int y = int.Parse(Console.ReadLine());
        //    int result=addion(x, y);
        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //}

        //static int addion(int a,int b)
        //{
        //    var result = a + b;
        //    return result;
        //}
        #endregion

        #region for string data type
        //static void Main(string[] args)
        //{

        //    Console.Write("enter the value of a : ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("enter the value of b : ");
        //    int y = int.Parse(Console.ReadLine());
        //    string result = addion(x, y);

        //    Console.WriteLine(result);

        //    Console.ReadLine();

        //}

        //static string addion(int a, int b)
        //{
        //    var result = a + b;
        //    return $"result={result}";
        //}
        #endregion

        #region for int data type using if statement
        //static void Main(string[] args)
        //{

        //    Console.Write("enter the value of a : ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("enter the value of b : ");
        //    int y = int.Parse(Console.ReadLine());
        //    int result = addion(x, y);
        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //}

        //static int addion(int a, int b)
        //{
        //    if (a>b)
        //    {
        //        return (a + b);

        //    }
        //    else
        //    {
        //        return (a - b);
        //    }
        //}
        #endregion

        #region for void return data type
        static void Main(string[] args)
        {
            addion(-10);
            Console.WriteLine("invalid");

            Console.ReadLine();

        }

        static void addion(int a)
        {

            if (a<0)
            {
                return;
            }
       
        }
        #endregion
    }
}
