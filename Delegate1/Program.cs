using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursion

{
    public delegate void MyDelegate(int number);

    public class Program
    {
        public static int i=0;

        public static int Recursion(int number)
        {
            MyDelegate d = new MyDelegate(Din);
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number);
                d.Invoke(number);
                return number;
            }
            else
            {
                var result = Recursion(number - 1) + Recursion(number - 2);
                Console.WriteLine(result);
                d.Invoke(number);
                return result ;
            }
        }
        public static void Din(int number)
        {
            if (number> 0)
            {
                float x;
                x =(float) ((i / number) * 100);
                Console.Write("\t" + x + "%" + "\n");
            }
            ++i;
        }
        public static void Main()
        {
             i = 0;
            Console.Write("Give the length\n");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci series" + "\tPercentage"+"\n");
            var fibonacciResult = Recursion(number);
            // Console.Write(" " + Recursion(number));
            //Console.WriteLine(fibonacciResult);
            Console.ReadKey();
        }

    }

}
