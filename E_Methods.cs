using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class E_Methods
    {
        internal void CreatingMethods()
        {
            // Call void  Method with param input
            DisplayWelcomeMsg("Vijay Gawade");

            // Pass by Refference
            int myScore = 75;
            GetExtraCredit(ref myScore);
            Console.WriteLine(myScore);

            // Out keyword to return multiple values
            int addition, multplication;
            AddAndMult(4, 5, out addition, out multplication);
            Console.WriteLine(addition + "\t" + multplication);

            // Pass any # of argumemts(int) to method using 'Params' keyword
            DisplayArrayElement(1, 2, 3, 4);
            DisplayArrayElement(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            // Method Overloading: 1. diff amt of input params      2. diff types of inputs
            Add(5, 6);
            Add(7, 8, 9);
            Add("Vijay", "Gawade");

            // Optional Parameter with default value
            IncrementValue(50, 2);
            IncrementValue(50);

            // Named parameters
            WelcomeMsg("vijay", "Gawade");          // Default input seq
            WelcomeMsg(fname : "Vijay", lname: "Gawade");   // pass params with name
            WelcomeMsg(lname: "Gawade", fname: "Vijay");    // pass params with any order using named params

            Exercise1_MultiPlication_Table();
            Exercise2_GetCubeAndSquareOfNumber();
            Exercise3_SumOfIntArgs();
        }

        // Create Methods with Param 
        void DisplayWelcomeMsg(string userName)
        {
            Console.WriteLine("Welcome " + userName);
        }

        // Parameter Pass By Refference using Ref keyword
        void GetExtraCredit(ref int score)
        {
            score += 5;
        }

        // Parameter  Pass By Refference using out Keywords
        void AddAndMult(int a,int b,out int add,out int mult)
        {
            add = a + b;
            mult = a * b;
        }

        // Params Keyword used to pack multiple arguments into single object/array
        void DisplayArrayElement(params int[] arr)
        {
            foreach (int ele in arr)
                Console.Write(ele + "\t");
            Console.WriteLine();
        }

        // Method Overloading: diff # of inputs
        void Add(int a,int b)
        {
            Console.WriteLine((a + b));
        }

        void Add(int a,int b,int c)
        {
            Console.WriteLine((a + b + c));
        }

        // Method Overloading: diff input types
        void Add(string a,string b)
        {
            Console.WriteLine(a + " " + b);
        }

        // Optional Parameter with default value
        void IncrementValue(int num,int incrementBy = 1)
        {
            Console.WriteLine((num + incrementBy));
        }

        // Named Parameters
        void WelcomeMsg(string fname,string lname)
        {
            Console.WriteLine("Welcome " + lname + " " + fname);
        }

        void Exercise1_MultiPlication_Table()
        {
            Console.Write("Enter Number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0,-2} * {1,-2} = {2,-2}",num,i,num*i);
            Console.WriteLine();
        }

        void Exercise2_GetCubeAndSquareOfNumber()
        {
            Console.Write("Enter Number: ");
            int num = int.Parse(Console.ReadLine());

            int cube, square;
            Cube(num, out cube, out square);

            Console.WriteLine("num={0} \t Square= {1} \t Cube= {2}", num, square, cube);
        }

        void Cube(int num,out int cube,out int square)
        {
            Square(num, out square);
            cube = square * num;
        }

        void Square(int num,out int square)
        {
            square = num * num;
        }

        void Exercise3_SumOfIntArgs()
        {
            Sum(1, 2, 3, 4);
            Sum(5, 6, 7, 8, 9, 10, 11, 12, 14, 13, 15);
        }

        void Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int n in nums)
                sum += n;
            Console.WriteLine("Sum is " + sum);
        }
    }
}
