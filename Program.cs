using ConsoleProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleprogram
{
    public class Program 
    {
        public static void Main()
        {
            Class1.Read();
            //Class1.Array(Convert.ToInt32(Console.ReadLine()));
            Class1.disp(Class1.Array(Convert.ToInt32(Console.ReadLine())));
        }

           
    }
}