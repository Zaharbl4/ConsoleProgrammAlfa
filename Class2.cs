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
        public static void Disp(int[] array,int var)
        {
            Console.WriteLine(array[var]);
        }
        public static void dispArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        public static int[] ArrayN(int size, int arrayN)
        {
            int[] array = new int[size];
           
            for (int i = 0; i < size; i++)
            {
                array[i] = arrayN++;
            }
            return array;
        }
        public static int[] ArrayR(int size, int randomN, int randomN1)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                var rand = new Random();
                array[i] = rand.Next(randomN ,randomN1);
            }
            return array;
        }

    }
}
