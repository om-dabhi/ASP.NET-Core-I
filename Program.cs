using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace CSharpFunda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to print your name, address, contact number & city.

            /*Console.WriteLine("Om Dabhi");
            Console.WriteLine("Address");
            Console.WriteLine("omdabhi2905@gmail.com");
            Console.WriteLine("Rajkot");*/

            //2.Write a program to get two numbers from user and print those two numbers.

            /*Console.WriteLine("Enter Number1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number1: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N1: " + n1);
            Console.WriteLine("N2: " + n2);*/

            //3.Write program to prompt a user to input his/ her name and country name and then output will be shown as given: Hello<yourname> from country <countryname>

            /*Console.WriteLine("Enter Your Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Your Country: ");
            String country = Console.ReadLine();
            Console.WriteLine("Hello "+name+" from Country "+country);*/

            //4. Write a program to calculate the size of the area in square-feet based on Specified length and width.

            /*Console.Write("Enter the length in feet: ");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter the width in feet: ");
            float width = float.Parse(Console.ReadLine());
            float area = length * width;
            Console.WriteLine("The area is: " + area + " square feet.");*/

            //5. Write a program to calculate area of Square, Rectangle and Circle.
            /*Console.WriteLine("Area Calculator");
            Console.WriteLine("----------------");

            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the side length of the square: ");
                float side = float.Parse(Console.ReadLine());

                float area = side * side;
                Console.WriteLine("The area of the square is: " + area);
                break;
            case 2:
                Console.Write("Enter the length of the rectangle: ");
                float length = float.Parse(Console.ReadLine());

                Console.Write("Enter the width of the rectangle: ");
                float width = float.Parse(Console.ReadLine());

                float rectarea = length * width;
                Console.WriteLine("The area of the rectangle is: " + rectarea);
                break;
            case 3:
                Console.Write("Enter the radius of the circle: ");
                float radius = float.Parse(Console.ReadLine());

                double cirarea = 3.14 * radius * radius;
                Console.WriteLine("The area of the circle is: " + cirarea);
                break;
            case 4:
                Console.WriteLine("Exiting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting the program.");
                break;
        }*/

            //6. Write a program to calculate Celsius to Fahrenheit and vice-versa function.

            /* Console.WriteLine("Temperature Converter");
             Console.WriteLine("---------------------");

             Console.WriteLine("1. Celsius to Fahrenheit");
             Console.WriteLine("2. Fahrenheit to Celsius");
             Console.WriteLine("3. Exit");

             Console.Write("Enter your choice (1-3): ");
             int choice = int.Parse(Console.ReadLine());

             switch (choice)
             {
                 case 1:
                     ConvertCelsiusToFahrenheit();
                     break;
                 case 2:
                     ConvertFahrenheitToCelsius();
                     break;
                 case 3:
                     Console.WriteLine("Exiting the program.");
                     break;
                 default:
                     Console.WriteLine("Invalid choice. Exiting the program.");
                     break;
             }
         }

         static void ConvertCelsiusToFahrenheit()
         {
             Console.Write("Enter the temperature in Celsius: ");
             float celsius = float.Parse(Console.ReadLine());

             float fahrenheit = (celsius * 9 / 5) + 32;
             Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
         }

         static void ConvertFahrenheitToCelsius()
         {
             Console.Write("Enter the temperature in Fahrenheit: ");
             float fahrenheit = float.Parse(Console.ReadLine());

             float celsius = (fahrenheit - 32) * 5 / 9;
             Console.WriteLine("The temperature in Celsius is: " + celsius);*/

            //7. Write a program to find out Simple Interest using function. (I = PRN/100)

            /* Console.WriteLine("Simple Interest Calculator");
             Console.WriteLine("-------------------------");

             Console.Write("Enter the principal amount: ");
             float principal = float.Parse(Console.ReadLine());

             Console.Write("Enter the rate of interest (in percentage): ");
             float rate = float.Parse(Console.ReadLine());

             Console.Write("Enter the time period (in years): ");
             float time = float.Parse(Console.ReadLine());

             float interest = CalculateSimpleInterest(principal, rate, time);

             Console.WriteLine("The simple interest is: " + interest);
         }

         static float CalculateSimpleInterest(float principal, float rate, float time)
         {
             float interest = (principal * rate * time) / 100;
             return interest;*/

            //8. Write a program to create a Simple Calculator for two numbers (Addition, Multiplication, Subtraction, Division) [Also using if…else &Switch Case]

            /*Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose the operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            if (choice >= 1 && choice <= 4)
            {
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid choice.");
            }*/

            //9. Write a program to find maximum numbers from given 3 numbers.

            /*Console.WriteLine("Maximum Number Finder");
            Console.WriteLine("---------------------");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = FindMaximum(num1, num2, num3);

            Console.WriteLine("The maximum number is: " + max);
        }

        static int FindMaximum(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            return max;*/

            //10. Write a program to Swapping without using third variable.

            /*Console.WriteLine("Number Swapper");
            Console.WriteLine("--------------");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            SwapNumbers(ref num1, ref num2);

            Console.WriteLine("After swapping:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
        }

        static void SwapNumbers(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;*/
        }
    }
}