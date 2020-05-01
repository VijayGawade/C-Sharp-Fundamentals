using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class A_UsingData
    {
        private enum Gender
        {
            Male='M',
            Female='F',
            Other='O'
        }

        public static void DeclareVariable()
        {
            int a=4;
            float b;
            double c;
            bool d;
            char e='A';
            string f;

            Console.WriteLine("Variable '{0}' of type {1} with  value\nRight Justify:{2,5}\n Left Justify:{2,-5}"
                                , nameof(a), a.GetType().Name, a);
        }

        public static void ArithmeticOperators()
        {
            Console.WriteLine("\nArithmetic Operation in C#: ");
            int a = 7, b = 3,c=5;
            Console.WriteLine("a={0}\tb={1}\tc={2}", a, b, c);

            Console.WriteLine("a+b=" + (a + b));
            Console.WriteLine("a-b=" + (a - b));
            Console.WriteLine("a*b=" + (a * b));

            Console.WriteLine("a/b=" + (a / b));
            Console.WriteLine("double(a)/b=" + ((double)a / b));

            Console.WriteLine("a%b=" + (a % b));

            /*
                First Precedence: *,/, %  same pricision with evaluated left to right
                Second Precedence:  +,-  have same prision 
                Chnage Precedence: using () paranthesis             
             */
            Console.WriteLine("\nOperators Precedence in C#:");
            Console.WriteLine("(a + b * c)="+ (a + b * c));
            Console.WriteLine("(a / b - c)=" + (a / b - c));
            Console.WriteLine("((a + b) / c)=" + ((a + b) / c));

            Console.WriteLine("\nAssignment operators in C#:");
            Console.WriteLine("(a+=3) =" + (a+=3));
            Console.WriteLine("(a-=3) = " + (a-=3));
            Console.WriteLine("(a*=3) = " + (a*=3));
            Console.WriteLine("(a/=3) = " + (a/=3));

            Console.WriteLine("\nIncrement & Decrement Operator with postfix & prefix");
            Console.WriteLine("Initial Values: a={0}\tb={1}", a, b);
            Console.WriteLine("Values while Increment Operator(with postfix): a={0}\tb={1}", a++, b++);
            Console.WriteLine("Values after Increment Operator(with postfix): a={0}\tb={1}", a, b);
            Console.WriteLine("Curent Values: a={0}\tb={1}", a, b);
            Console.WriteLine("Values while Increment Operator(with prefix): a={0}\tb={1}", ++a, ++b);
            Console.WriteLine("\nCurent Values: a={0}\tb={1}", a, b);
            Console.WriteLine("Values while Decrement Operator(with postfix): a={0}\tb={1}", a--, b--);
            Console.WriteLine("Values after Decrement Operator(with postfix): a={0}\tb={1}", a, b);
            Console.WriteLine("Values while Decrement Operator(with prefix): a={0}\tb={1}", --a, --b);
        }

        public static void StringDataType()
        {
            string str1 = "Vijay";
            string str2 = "Vijay";

            /*
                str1.CompareTo(str2)
                    0: both string are equal
                   -1: first string is less
                    1: second string is less
            */

            Console.WriteLine("\nCheck String equality using differnt ways:");
            Console.WriteLine("str1={0}\tstr2={1}", str1, str2);
            Console.WriteLine("Using '==' operator: " + (str1 == str2));
            Console.WriteLine("Using equals method: " + str1.Equals(str2));
            Console.WriteLine("Using compare method: " + str1.CompareTo(str2));
            str2 = "vijay";
            Console.WriteLine("str1={0}\tstr2={1}", str1, str2);
            Console.WriteLine("Using '==' operator: " + (str1 == str2));
            Console.WriteLine("Using equals method: " + str1.Equals(str2));
            Console.WriteLine("Using compare method: " + str1.CompareTo(str2));

            Console.WriteLine("Length of string \"{0}\" using Length property is {1}", str1, str1.Length);

            // Substring(start index,length);
            // str1.Substring(2, 5) mean string start from 2 to 4 index
            Console.WriteLine("Get Substring using Substring method: " + "This is first sentence".Substring(1, 10));

            Console.WriteLine("Startwith function : " + str1.StartsWith("Vi"));
        }

        public static void NumericConversion()
        {
            Console.WriteLine("\nNumeric Conversion in C#:");
            int x = 5;
            double y = x;  // implicit conversion when NO DATA LOSS
            Console.WriteLine("x={0}\ty={1}",x,y);

            y = 5.5;
            x = (int)y;     // explicit conversion when DATA LOSS
            Console.WriteLine("x={0}\ty={1}", x, y);
        }

        public static void DeclaringConstants()
        {
            const double PI = Math.PI;
            Console.WriteLine("Contant PI=" + PI);

            Gender myGender=Gender.Male;
            Console.WriteLine("Enum: " + myGender);
            Console.WriteLine("Enum: " + (char)myGender);
        }

        public static void ReadConsoleInput()
        {
            Console.WriteLine("\nReading Console Inputs:");
            Console.Write("Enter your Name: ");
            string sname = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Information:");
            Console.WriteLine("Name:" + sname);
            Console.WriteLine("Age:" + age);                        
        }

        public static void Exercise1_AddIntCalculator()
        {
            Console.Write("Enter First Number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition of {0} and {1} is {2}.", firstNum, secondNum, (firstNum + secondNum));
        }

        internal static void Exercise2_CarpetCostCalculator()
        {
            const double cost = 4.5;
            Console.Write("Enter Lenght of Room: ");
            double roomLength = double.Parse(Console.ReadLine());
            Console.Write("Enter Width of Room: ");
            double roomWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Cost for Carpeting Room willl be " +roomLength*roomWidth*cost);
        }

        public static void Exercise3_MinutesToHMConverter()
        {
            Console.Write("Enter total amt of time in mins: ");
            int timeMinute = int.Parse(Console.ReadLine());

            Console.WriteLine("Time in H:M format= {0}:{1}" , timeMinute / 60, timeMinute % 60);
        }
    }
}
