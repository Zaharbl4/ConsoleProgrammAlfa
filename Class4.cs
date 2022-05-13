using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    internal class Class4
    {
       
      public static void Ds()
        {
            switch (Class3.Input("Заполнить массив? 1-да  2-нет"))
            {
                case 1:
                    Console.WriteLine("укажите размер массива");
                    Variable size = new Variable();
                    size.Value = Class3.Input("укажите размер массива");    
                    Console.WriteLine("заполнить по порядку - 1 или рандомными значениями - 2?");
                    switch (Class3.Input("заполнить по порядку - 1 или рандомными значениями - 2?"))
                    {
                            case 1:                          
                            Console.WriteLine("введите начальное значение");
                            Variable arrayN = new Variable();
                            arrayN.Value = Class3.Input("введите начальное значение");
                            //Class2.ArrayN(size.Value, arrayN.Value);
                           
                            Console.WriteLine("вывести содержимое массива? 1 - да 2 - нет");
                            switch (Class3.Input("вывести содержимое массива? 1 - да 2 - нет"))
                            {
                                case 1:
                                    Console.WriteLine(" вывести полностью - 1 вывести 1 элемент _ 2 ");
                                    switch (Class3.Input("вывести полностью - 1 вывести 1 элемент - 2 "))
                                    {
                                        case 1:
                                            Class2.dispArray(Class2.ArrayN(size.Value, arrayN.Value));
                                            break;
                                        case 2:
                                            Console.WriteLine("укажите 1 элемент из {0} ", size.Value);
                                            Variable arraySize = new Variable();
                                            arraySize.Value = Class3.Input("укажите 1 элемент");
                                            Class2.Disp(Class2.ArrayN(size.Value, arrayN.Value), arraySize.Value);
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("выполнить сначала? 1 - да 2 - нет");
                                    switch (Class3.Input("выполнить сначала? 1 - да 2 - нет"))
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                            case 2:
                            Console.WriteLine("укажите  диапазон ");
                            Console.WriteLine("укажите  число нижнего предела ");
                            Variable randomN = new Variable();
                            randomN.Value = Class3.Input("укажите  число нижнего предела");
                            Console.WriteLine("укажите  число верхнего предела ");
                            Variable randomN1 = new Variable();
                            randomN1.Value = Class3.Input("укажите  число верхнего предела");
                           
                            Console.WriteLine("вывести содержимое массива? 1 - да 2 - нет");
                            switch (Class3.Input("вывести содержимое массива? 1 - да 2 - нет"))
                            {
                                case 1:
                                    Console.WriteLine(" вывести полностью - 1 вывести 1 элемент из ");
                                    switch (Class3.Input(" вывести полностью - 1 вывести 1 элемент - 2 "))
                                    {
                                        case 1:
                                            Class2.dispArray(Class2.ArrayR(size.Value, randomN.Value, randomN1.Value));
                                            break;
                                        case 2:
                                            Console.WriteLine("укажите 1 элемент из {0} ", size.Value);
                                            Variable arraySize = new Variable();
                                            arraySize.Value = Class3.Input("укажите 1 элемент");
                                            Class2.Disp(Class2.ArrayR(size.Value, randomN.Value, randomN1.Value), arraySize.Value);
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("выполнить сначала? 1 - да 2 - нет");
                                    switch (Class3.Input("выполнить сначала? 1 - да 2 - нет"))
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }

                            break;
                        default:
                           // Console.WriteLine("не тупи, написано ведь 1 или 2");
                            break;
                    }

                    //Class3.Output("ZOEBIS");
                    break;
                   
                case 2:
                    Console.WriteLine("я ведь старался давай да");
                    //Class3.Output(" NE ZOEBIS");
                    break;
                default:
                    Console.WriteLine("не тупи, написано ведь 1 или 2");
                    break;
                   

                    

            }
        }




    }
}
