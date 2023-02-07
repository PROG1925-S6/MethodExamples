using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, answer;
            double radiusSize, circleArea;
            string firstName, pinInput;

            //RectangleArea();
            //PrintSignature();
            //MaxEfficiency();
            Console.Write("Please enter a number: ");
            firstNum = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please enter a number: ");
            secondNum = Convert.ToInt16(Console.ReadLine());

            Add(firstNum, secondNum);

            firstName = "Me";
            pinInput = "12345";

            WelcomeUser(firstName, pinInput);

            answer = Area(firstNum, secondNum);
            Console.WriteLine($"the area is: {answer}");

            radiusSize = 3;
            circleArea = Area(radiusSize);
            Console.WriteLine($"the area of the circle is: {circleArea}");

            Console.ReadKey();
        }

        // 1. Print a signature to the screen
        static void PrintSignature()
        {
            Console.WriteLine("Your's truly,  \nGrace Hopper\n");
        }

        // 2. Create a method to calculate the area of a rectangle
        static void RectangleArea()
        {
            int width, length, area;

            Console.Write("Please enter the width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the length:");
            length = Convert.ToInt32(Console.ReadLine());

            area = length * width;

            Console.WriteLine($"Area of a {length} by {width} rectangle is {area}units^2");
        }

        // 3. Create a method that will determine the maximum of 3 values
        static void Max()
        {
            int num1, num2, num3, max;

            Console.Write("Enter the first value: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the second value: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the third value: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"The max value is {max}");
        }

        static void MaxEfficiency()
        {
            int num1, num2, num3, max;

            Console.Write("Enter the first value: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the second value: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the third value: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //test 100 million times
            for (int i = 0; i < 100000000; i++)
            {
                max = num1;

                if (num2 > max)
                {
                    max = num2;
                }

                if (num3 > max)
                {
                    max = num3;
                }

                //if (num1 > num2 && num1 > num3)
                //{
                //    max = num1;
                //}

                //if (num2 > num1 && num2 > num3)
                //{
                //    max = num2;
                //}

                //if (num3 > num1 && num3 > num2)

                //{
                //    max = num2;
                //}

            }

            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds}");
        }

        // 4. Create an Add method, that accepts 2 int parameters
        static void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"{x} + {y} = {sum}");
        }

        // 5. Create a method called WelcomeUser, that accepts 2 string 
        //    parameters, name and pin. If the PIN is 1234 the program welcomes
        //    the user. If not an error message is displayed.
        static void WelcomeUser(string name, string pin)
        {
            if(pin == "1234")
            {
                Console.WriteLine($"Welcome {name}");
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }
        }

        // 6. Create a method called Area, that accepts 2 int parameters, (x and y),
        //    uses them to determine the area of a rectangle , and then returns the 
        //    result back to the method call.

        static int Area(int length, int width)
        {
            int area = length * width;
            return area;
        }

        static double Area(double radius)
        {
            double area = 3.14 * radius * radius;
            return area;
        }
    }
}
