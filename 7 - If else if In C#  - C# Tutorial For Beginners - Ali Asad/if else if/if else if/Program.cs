using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            #region not optamised way

            //int Marks=55;
            //string Grade = "";

            //if (Marks > 40 && Marks < 50)
            //{
            //    Grade = "c";
            //}
            //if (Marks>50 && Marks <60)
            //{
            //    Grade = "B";
            //}
            //if (Marks>60 && Marks < 70)
            //{
            //    Grade = "A";
            //}
            //if (Marks >80 && Marks <100)
            //{
            //    Grade = "A+";
            //}
            //if (Marks<40)
            //{
            //    Grade = "F";
            //}

            Console.WriteLine("Your Grade is : {0}",Grade);
            #endregion


            #region  optamised way

           // int Marks = 55;
           // string Grade = "";

           // if (Marks > 40 && Marks < 50)
           // {
           //     Grade = "c";
           // }
           //else if (Marks > 50 && Marks < 60)
           // {
           //     Grade = "B";
           // }
           //else if (Marks > 60 && Marks < 70)
           // {
           //     Grade = "A";
           // }
           //else if (Marks > 80 && Marks < 100)
           // {
           //     Grade = "A+";
           // }
           //else if (Marks < 40)
           // {
           //     Grade = "F";
           // }

           // Console.WriteLine("Your Grade is : {0}", Grade);
            #endregion


        }
    }
}
