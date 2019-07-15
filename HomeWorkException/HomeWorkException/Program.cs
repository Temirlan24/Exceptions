using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.реализовать метод деления двух чисел. Внутри метода проверять входящие параметры. 
              Если они не заданы, то генерировать исключение ArgumentNullException. 
             Если делитель равен нулю, то генерировать исключение ArgumentException. */
             try
            {
                Console.WriteLine("Введите число X:");
                int firstNumber=int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число Y:");
                int secondNumber=int.Parse(Console.ReadLine());
                int result = firstNumber / secondNumber;
                Console.WriteLine("Result = {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат!!!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на ноль!!!");
            }
            Console.ReadKey();

            /*2. 2.Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
             После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.*/
             int[] array = new int[5];
             Random random = new Random();
             for(int i = 0; i < 5; i++)
             {
                 array[i] = random.Next(1, 20);
                 Console.Write(array[i] + "\t");
             }
             Console.WriteLine();
             try
             {
                 for(int i = 0; i < 10; i++)
                 {
                     Console.Write(array[i] + "\t");
                 }
             }
             catch (IndexOutOfRangeException)
             {
                 Console.WriteLine();
                 Console.WriteLine("Выход за границу массива");
             }
             finally
             {
                 Console.WriteLine();
                 Console.WriteLine("Программа успешно заверешена");
             }
             Console.ReadKey();
             
        }
    }
}
