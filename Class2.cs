using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProgram;

namespace ConsoleProgram
{
    internal class Class2
    {
        public static void disp(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

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
