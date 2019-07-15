using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    class ClassExceptionsWithMethods
    {
        public void ChekArray(int[] array, int length)
        {
            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public void FillArray(int elementLength,int length)
        {
            int[] array = new int[elementLength];
            Random random = new Random();
            for(int i = 0; i < elementLength; i++)
            {
                array[i] = random.Next(1, 20);
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            ChekArray(array, length);
        }
    }
}
