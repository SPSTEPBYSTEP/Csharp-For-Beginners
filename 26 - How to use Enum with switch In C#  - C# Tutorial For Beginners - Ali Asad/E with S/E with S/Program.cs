using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_with_S
{
    class Program
    {
        enum Gender
        {
            Mail, Femail, Gey, Lesbian
        }
        static void Main(string[] args)
        {
            Console.Write("enter 0 for Mail, 1 for Femail, 2 for gey and 3 for Lesbian :");
            int index = int.Parse(Console.ReadLine());
            Gender g = (Gender)index;

            switch (g)
            {
                case Gender.Mail:
                    Console.WriteLine("i am Mail");
                    Console.ReadLine();
                    break;
                case Gender.Femail:
                    Console.WriteLine("i am FeMail");
                    Console.ReadLine();

                    break;
                case Gender.Gey:
                    Console.WriteLine("i am gey");
                    Console.ReadLine();

                    break;
                case Gender.Lesbian:
                    Console.WriteLine("i am Lesbian");
                    Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("invalid entry");
                    Console.ReadLine();

                    break;
            }

        }
    }
}
