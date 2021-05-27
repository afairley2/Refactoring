using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refractoring_example
{
    class Program
    {

        //recursive loop that loads up the stack, can cause memory issues
        static void Main(string[] args)
        {
            long factorial = Rfactorial(4);
            Console.WriteLine(factorial);

            Console.ReadLine();
        }

        public static long Rfactorial(long v)
        {
            if (v == 1)
                return 1;
            else
                return v + Rfactorial(v - 1);
        }


        //same thing but just by using a loop, only needs one instance
        public static long Factorial(long v)
        {
            long num = 1;
            while (v > 1)

                num = num * v;
            v--;

            return num;
        }
    }
}
