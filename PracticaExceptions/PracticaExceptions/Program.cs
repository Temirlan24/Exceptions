using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassExceptionsWithMethods exception = new ClassExceptionsWithMethods();
            try
            {
                exception.FillArray(5, 7);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nВыход за границу массива!!!");
            }
            Console.ReadKey();
        }
    }
}
