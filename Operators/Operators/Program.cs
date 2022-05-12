using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num1;
            //double num2;
            //double result;

            //Console.WriteLine("*******Airthematic Operations**********");

            //Console.Write("Enter num1: ");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //num2 = Convert.ToDouble(Console.ReadLine());
            ////Addition Operator
            //result = num1 + num2;
            //Console.WriteLine("Sum of {0} + {1} = {2}", num1, num2, result);
            ////Console.WriteLine("Sum of " + num1 + " + " + num2 + " = " + result);
            ////Subtraction Operator
            //result = num1 - num2;
            //Console.WriteLine("Subtraction of {0} - {1} = {2}", num1, num2, result);
            ////Multiplication
            //result = num1 * num2;
            //Console.WriteLine("Multiplication of {0} * {1} = {2}", num1, num2, result);
            ////Division
            //result = num1 / num2;
            //Console.WriteLine("Division of {0} / {1} = {2}", num1, num2, result);
            ////Modulus
            //result = num1 % num2;
            //Console.WriteLine("Modulus of {0} % {1} = {2}", num1, num2, result);


            //RELATIONAL OPERATOR



            //LOGICAL OPERATORS
            int a;
            int b;
            int c;
            bool res;
            Console.Write("Enter value a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value c: ");
            c = Convert.ToInt32(Console.ReadLine());
            //AND LOGICAL OPERATOR
            res = (a == b) && (c > b);
            Console.WriteLine("({0} == {1}) && ({2} > {1}) returns {3}", a, b, c, res);
            //OR LOGICAL OPERAYOR
            res = (a == b) || (c < b);
            Console.WriteLine("({0} == {1}) || ({2} < {1}) returns {3}", a, b, c, res);
            //NOT LOGICAL OPERATOR
            res = !(a != b);
            Console.WriteLine("!({0} != {1}) returns {2}",a,b,res);

            Console.Read();


        }
    }
}
