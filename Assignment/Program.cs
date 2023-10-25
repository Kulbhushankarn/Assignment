using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {

            public int Add(int a, int b)
            {
                return a + b;
            }


            public double Add(double a, double b)
            {
                return a + b;
            }

            public int Add(params int[] numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }

            public string Add(string a, string b)
            {
                return a + b;
            }

            static void Main()
            {
                Program program = new Program();

                int intSum = program.Add(5, 10);
                Console.WriteLine("Sum of two integers: " + intSum);

                double doubleSum = program.Add(2.5, 4.3);
                Console.WriteLine("Sum of two doubles: " + doubleSum);

                int paramSum = program.Add(2, 4, 6, 8, 10);
                Console.WriteLine("Sum of multiple integers using params: " + paramSum);

                string concatenatedString = program.Add("Hello, ", "World!");
                Console.WriteLine("Concatenated string: " + concatenatedString);
        }
    }
}

/*Does method overloading is depend on return types.
*/

/*No, method overloading in C# is not dependent on the return type. 
Method overloading is determined based on the method's name and the parameter list, 
    which includes the number and types of parameters. 
    The return type is not considered when determining method overloads.*/

