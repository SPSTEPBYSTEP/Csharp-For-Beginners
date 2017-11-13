using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Gender { male, femail, gey, lesbian }

        static void Main(string[] args)
        {
            #region direct values

            //string name = "Nisar Ahmed";
            //Gender g = Gender.male;

            //Console.WriteLine("my name is {0} and i am {1}", name, g);
            //Console.ReadLine();
            #endregion

            #region get values from users
           // Console.Write("enter your name :");
           // string name = Console.ReadLine();
           // Console.Write("0 for mail, 1 for femail, 2 for gey, 3 for lesbian :");
           // int index = int.Parse(Console.ReadLine());

           //Gender g = (Gender)index;

           // Console.WriteLine("my name is {0} and i am {1}", name, g);
           // Console.ReadLine();

            #endregion

        }

    }
}
