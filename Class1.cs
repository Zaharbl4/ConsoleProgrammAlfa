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
            bool invalid, invalid1;

            

            do
            {
                invalid1 = true;
                
                String? response = Console.ReadLine();
                if (int.TryParse(response, out int num))
                {

                    switch (num)
                    {
                        case 1:

                            Console.WriteLine("введите число до которого необходимо заполнить массив");                                                       
                            do// do while защита от пустого ввода
                            {
                                invalid = true;
                               
                                String? response1 = Console.ReadLine();
                                if (int.TryParse(response1, out int num1))
                                {
                                    Class2.disp(Class2.Array(num1));
                                  
                                }
                                else
                                {
                                    Console.WriteLine("не тупи, написано ведь 1 или 2");
                                }
                                invalid = false;
                            } while (invalid);
                          


                            break;
                        case 2:
                            
                            break;


                        default:
                            Console.WriteLine("не тупи, написано ведь 1 или 2");

                            break;
                            
                    }
                    invalid1 = false;

                }
                else
                {
                    Console.WriteLine("не тупи, написано ведь 1 или 2");
                }
            } while (invalid1);





        }
      
    }
}
