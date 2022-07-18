using System;

namespace DemoAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte using third variable
            int a, b, temp;
            a = 8;
            b = 4;

            temp = a;
            a = b;
            b = temp;
            // Without using third variable
            //Addition nd suubstraction

            //a=a+b;
            //b=a-b;
            //a=a-b;

            // By using multiplying number

            // a = a * b;
            //b = a / b;
            //a = a / b;


            Console.WriteLine(a + " " + b);
        }
    }

    class PrintNumber
    {
        public static void Main(string[] args)
        {

            int i;
            i = 15;
            for (i = 15; i <= 25; i++)
            {
                Console.WriteLine(+i);
            }
        }
    }

    class Trangle
    {
        static void Main(string[] args)
        {
            int w, h;
            float area;
            w = 4;
            h = 4;
            area = (w * h) / 2;
            Console.WriteLine(area);
        }
    }
    class Rectangle
    {
        public static void Main(string[] args)
        {
            int len, w, a;
            len = 4;
            w = 8;
            a = len * w;
            Console.WriteLine(+a);
        }
    }
    class CubeOfNumber
    {
        public static void Main(string[] args)

        {
            int num, result;
            num = 4;
            result = num * num * num;
            Console.WriteLine(num);
        }
    }
    class EvenOrOdd
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is Even ");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }
        }
    }
    class Divisible
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 5 == 0)
            {
                Console.WriteLine("Entered number Divisible by five");
            }
            else
            {
                Console.WriteLine("Entered number is not divisible by five");
            }
        }
    }
    class Greater
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + "  is greater");
            }
            else
            {
                Console.WriteLine(num2 + "  is greater");
            }
        }
    }
    class Vowel
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
    class BloodDonation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter weight");
            int wt = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                if (wt > 52)
                {
                    Console.WriteLine("person is valid for blood donation");
                }
                else
                {
                    Console.WriteLine("person is not valid for blood donation due to under weight");
                }
            }
            else
            {
                Console.WriteLine("not valid for blood donation");
            }
        }
    }
    class Marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name...");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Roll number...");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Class...");
            int std = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics marks...");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Mathematics Marks...");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English marks...");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemisty marks...");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Bology marks...");
            int b = int.Parse(Console.ReadLine());

            int total = p + m + e + c + b;
            int per = (100 * total) / 500;

            Console.WriteLine(" Your Name is : " + name);
            Console.WriteLine(" Your roll nmber is: " + roll);
            Console.WriteLine(" Your Class is :" + std);
            Console.WriteLine(" Total marks are: " + total);
            Console.WriteLine(" Your Percentage is: " + per, "%");

            if (per > 80)
            {
                Console.WriteLine(" Student Pass with A-1 grade");
            }
            else if (per > 70)
            {
                Console.WriteLine("  Student Pass with A grade");
            }
            else if (per > 60)
            {
                Console.WriteLine(" Student Pass with B grade");
            }
            else if (per > 50)
            {
                Console.WriteLine("  Student Pass with C grade");
            }
            else if (per > 40)
            {
                Console.WriteLine(" Student Pass with D grade");
            }
            else
            {
                Console.WriteLine("  Student is Fail...");
            }
        }
    }

    class SwitchCase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
            switch (num1 % 2 == 0)
            {
                case true:
                    Console.WriteLine("number is even");
                    break;
                case false:
                    Console.WriteLine("number is odd");
                    break;
                default:
#pragma warning disable CS0162 // Unreachable code detected
                    Console.WriteLine("Number is a zero");
#pragma warning restore CS0162 // Unreachable code detected
                    break;
            }
        }
    }
    class Week
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" enter number ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tusday");
                    break;
                case 3:
                    Console.WriteLine("wednesday ");
                    break;
                case 4:
                    Console.WriteLine("thursday ");
                    break;
                case 5:
                    Console.WriteLine("friday ");
                    break;
                case 6:
                    Console.WriteLine("saturday ");
                    break;
                case 7:
                    Console.WriteLine("sunday ");
                    break;
                default:
                    Console.WriteLine("invalid ");
                    break;

            }
        }
    }
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter 1st nmber ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd nmber ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("arithmatics operations are \n 1. addition \n 2. subtraction \n 3. multiplication \n 4 division \n");
            Console.WriteLine("enter choise ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("addition of two number is :" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("subtraction of two nmber is : " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("multiplicatioon of two nmber is " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("division of two nmber is " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("envalid nmber ");
                    break;
            }
        }
    }
    class GrossSalary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter basic salary ");
            int bs = Convert.ToInt32(Console.ReadLine());
            double grs;
            // double da, hra;

            if (bs <= 10000)
            {
                //da = bs * ( da / 100);
                //hra = bs * (hra / 100);
                //gs = bs + da +   hra;
                grs = bs + bs * (0.8 + 0.2);
                Console.WriteLine("gross salary is " + grs);

            }
            else if (bs <= 20000)
            {
                grs = bs + bs * (0.25 + 0.9);
                Console.WriteLine("gross salary of basic salary  is " + grs);
            }
            else if (bs <= 20000)
            {
                grs = bs + bs * (0.3 + 0.95);
                Console.WriteLine("gross salary inclding da nd hra is " + grs);
            }
        }
    }
    class ElectricityBill
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter electricity consumption unit ");
            int unit = Convert.ToInt32(Console.ReadLine());
            double total;
            if (unit <= 50)
            {
                total = unit * 0.50;
                Console.WriteLine(" bill is " + total);
            }
            else if (unit <= 150)
            {
                total = (50 * 0.5) + ((unit - 50) * 0.75);
                Console.WriteLine(" bill is " + total);
            }
            else if (unit <= 150)
            {
                total = (50 * 0.5) + (100 * 0.75) + ((unit - 150) * 1.25);
                Console.WriteLine(" bill is " + total);
            }
            else if (unit <= 250)
            {
                total = (50 * 0.5) + (100 * 0.75) + (100 * 1.20) + ((unit - 250) * 1.50);
                Console.WriteLine(" bill is " + total);
            }
        }
    }
}


