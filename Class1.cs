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
         
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                    case 1:
                    Console.WriteLine("введите число до которого необходимо заполнить массив");
                    Class2.disp(Class2.Array(Convert.ToInt32(Console.ReadLine())));
                    break;
                    case 2:
                    Class1.Read();
                    Class1.Reading();
                    break;
                    default:
                    Console.WriteLine("не тупи, написано ведь 1 или 2");

                    break ;



            }

        }
      
    }
}
