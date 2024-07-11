using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintingNumbers(1, 2, 3, 4, 5, 6, 7, 8);
            PrintingNumbers(100, 115, 765);
            //this would get appended in the array
        }
        public static void PrintingNumbers(params int[] numbers)
        {
            //here we can only use params oned time andnot frequently.
            //it is required to declare params in the last if there are other parameters like string or any other.
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
