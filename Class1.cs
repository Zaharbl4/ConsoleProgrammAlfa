using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProgram;

namespace ConsoleProgram
{
    internal class Class1
    {
        public static void Read()
        {
            
            Console.WriteLine("Консольная программа");
            Console.WriteLine("Заполнить массив?");
            Console.WriteLine("1-да  2-нет");
            //string? a = Console.ReadLine();

        }
        public static void Reading()
        {
            //laibel:
            if (Convert.ToInt32(Console.ReadLine())==1)
            {
                Console.WriteLine("введите число до которого необходимо заполнить массив");
                Class2.disp(Class2.Array(Convert.ToInt32(Console.ReadLine())));
            }
            else if (Convert.ToInt32(Console.ReadLine())==2)
            {
             Class1.Read();
            }
            else
            {
                //goto laibel;
            }
        }
      
    }
}
