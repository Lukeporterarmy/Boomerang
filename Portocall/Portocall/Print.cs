using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    class Print
    {
        public void ShowArray<T>(T[] array)
        {
            Console.WriteLine("Complete Array");
            foreach(T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }

        public void ShowListOfArrays<T>(List<T[]> list)
        {
            int i = 0;
            for(; i < list.Count; i++)
            {
                T[] current = list[i];
                foreach(T item in current)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
