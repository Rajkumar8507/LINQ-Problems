using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Write a program in C# Sharp to show how the three parts of a query operation execute.
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var x = from element in array
                    where (element % 2 == 0)
                    select element;
            foreach (var element in x)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
            int[] array1 = { 1, -2, 3, -45, 6, -7, 8, -5 };
            var y = from element in array1
                    where (element >= 0)
                    select element;
            foreach (var element in y)
            {
                Console.WriteLine(element);
            }


        }
    }
}
