using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    internal class Class3
    {
        public static int Input(string error)
        {
            //  защита от пустого ввода
            bool invalid = true;
            int x=0;
            do
            {
                invalid = true;

                String? response = Console.ReadLine();
                if (int.TryParse(response, out int num))
                {
                    x = num;
                    invalid = false;

                }
                else
                {
                    Console.WriteLine("Не корректный ввод");
                    Console.WriteLine(error);

                }

            } while (invalid);
            return x;                    
        }
       
        
           
            
        
    }
}
