using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple if else if

           // string select;
           // Console.Write("Mian Metho khata ha ka select any number B/W 1-3 :");
           // select = Console.ReadLine();


           // if (select=="1")
           // {
           //     Console.WriteLine("You'll become success full developer");
           // }
           //else if (select=="2")
           // {
           //     Console.WriteLine("you'll get rich soon");
           // }
           //else if (select=="3")
           // {
           //     Console.WriteLine("To day is your lucky day");
           // }
           // else
           // {
           //     Console.WriteLine("Do not enter invalid entry");
           // }
            #endregion

            #region same work with Switch case

            string select;
            Console.Write("Mian Metho khata ha ka select any number B/W 1-3 :");
            select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("You'll become success full developer");
                    Console.ReadLine();

                    break;
                case "2":
                    Console.WriteLine("you'll get rich soon");
                    Console.ReadLine();

                    break;
                case "3":
                    Console.WriteLine("To day is your lucky day");
                    Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("Do not enter invalid entry");
                    break;
            }



            #endregion
        }
    }
}
