using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    internal class Class1
    {
        public static void Read()
        {
            Console.Write("Введите число ");
            
            
        
        }
        public static int[] Array(int size)
        {
            
            int[] array = new int[size];
           
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
            return array;
        }
    }
}
