using System;

namespace Assignment4
{

    //Number equal or not
    public class Looping
    {
        public static void Main()
        {

            int num1, num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }

            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }

            Console.ReadLine();
        }


        // Number even or odd
        public static void Main1()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Given Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Given Number is an Odd Number");
                Console.Read();
            }
        }


        // Number is Positive or Negative

        public static void Main2()
        {
            int i;
            Console.WriteLine("Enter the number");
            i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.Write("Number is Positive");

            }
            else
            {
                Console.Write("Number is negative");

            }
        }


        //For Leap Year

        public static void Main3()
        {
            int year;
            Console.Write("Enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("{0} is Leap Year", year);
            else
                Console.WriteLine("{0} is not a Leap Year", year);


            Console.ReadLine();
        }


        // For Candidate voter ID decision


        public static void Main4()
        {
            int i;
            Console.WriteLine("Enter the Value");
            i = int.Parse(Console.ReadLine());
            if (i > 18)
            {
                Console.Write("Congratulation! You are eligible for casting your vote.");

            }
            else
            {
                Console.Write("You are not eligible for casting your vote");

            }
        }

        // Read the value of integer and display enter value is greater than 5 n=1, or not n=-1
        public static void Main5()
        {
            int m;
            // Console.Write("Enter a Number : ");
            m = int.Parse(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("n = 1");
                Console.Read();
            }
            else if (m == 0)
            {
                Console.WriteLine("n = 0");
                Console.Read();
            }
            else if (m < 0)
            {
                Console.WriteLine("n = -1");
            }
            else
            {
                Console.WriteLine(" Entered parameter is not a number");
            }


        }


        // For decision making of height
        public static void Main6()
        {
            float height;
            Console.WriteLine("Enter  the Height (in centimeters) ");
            height = int.Parse(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("Dwarf ");
            }
            else if ((height >= 150.0) && (height <= 165.0))
            {
                Console.WriteLine(" Average Height ");
            }
            else if ((height >= 165.0) && (height <= 195.0))
            {
                Console.WriteLine("Taller ");
            }
            else
            {
                Console.WriteLine("Abnormal height \n");
            }
        }



        // Main Method 
        public static void Main7()
        {
            int a;
            int b;
            int c;
            int large;

            //input the numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            //finding largest number using if-else
            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;

            //printing 
            Console.WriteLine("Using if-else...");
            Console.WriteLine("Largest number is {0}", large);

            //finding largest number using ternary operator 
            large = (a > b && a > c) ? a : (b > a && b > c) ? b : c;

            //printing 
            Console.WriteLine("Using ternary operator...");
            Console.WriteLine("Largest number is {0}", large);

            //hit ENTER to exit the program
            Console.ReadLine();
        }



        //using System.IO;

        public static void Main8()
        {
            char grade;
            Console.WriteLine("Enter the Grade in UpperCase \n");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'E':
                    Console.WriteLine(" EXcellent ");
                    break;
                case 'V':
                    Console.WriteLine(" VERY GOOD");
                    break;
                case 'G':
                    Console.WriteLine(" Good ");
                    break;
                case 'A':
                    Console.WriteLine(" Average ");
                    break;
                case 'F':
                    Console.WriteLine(" FAIL");
                    break;
                default:
                    Console.WriteLine("ERROR IN GRADE ");
                    break;

            }
        }


        // using System.Collections.Generic;
        //using System.Text;

        public static readonly object digitswords;
        public static void Main9()
        {
            int value, next, numdigits;
            int[] a = new int[10];
            // words for every digits from 0 to 9
            string[] digitswords = 
            {
             "zero",
             "one",
             "two",
             "three",
             "four",
             "five",
             "six",
             "seven",
             "eight",
             "nine"
            };
            // number to be converted into words
            value = 4677;
            Console.WriteLine("Number: " + value);
            Console.Write("Number (words): ");
            next = 0;
            numdigits = 0;
            do
            {
                next = value % 10;
                a[numdigits] = next;
                numdigits++;
                value /= 10;
            } while (value > 0);
            numdigits--;
            for (; numdigits >= 0; numdigits--)
                Console.Write("digitswords[a[numdigits]] + ");
            Console.ReadLine();
        }


        // For pattern of triangle 
        public static void Main10()
        {
            int i, j, rows, k = 1;

            Console.Write("\n\n");
            Console.Write("Display the pattern like right angle triangle with number increased by 1:\n");
            Console.Write("---------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
        }


        // Pyramid Pattern
        public static void Main11()
        {
            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }






}
