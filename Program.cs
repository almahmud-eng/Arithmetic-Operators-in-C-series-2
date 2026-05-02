using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operators
{
    class Program
    {
        public static string F3 { get; private set; }

        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

           int sum = num1 + num2;
            int substraction = num2 - num1;
            int division = num2 / num1;
            int multiplication = num1 * num2;
            int remainder = num1 % num2; 
            //Console.WriteLine("Addition = " + (num1+num2));
            //Console.WriteLine(num1-num2);
            //Console.WriteLine(num2/num1);
            //Console.WriteLine(num1*num2);
            //Console.WriteLine(num2%num1);
            //Console.WriteLine(num1%num2);
            Console.WriteLine(" Sum = "+ sum); 
            Console.WriteLine(" Substraction = "+ substraction); 
            Console.WriteLine(" Division = "+ division); 
            Console.WriteLine(" Multiplication = "+ multiplication); 
            Console.WriteLine(" Remainder = "+ remainder);

            // we can do another simple way without declaring data type multiple times
            int resultant;
            int value1 = 5;
            int value2 = 6;
            resultant = value1 + value2;

            Console.WriteLine(" Sum = " + resultant);
            resultant = value2 - value1;

            Console.WriteLine(" substraction = " + resultant);

           double resultant1 = (double) value1 / value2; // When we divided a double number by integer number the resultant will always be a double number
            Console.WriteLine("Division = " + resultant1.ToString("F3"));// formating with 3 decimal number after .


            Console.ReadLine();

        }
    }
}
