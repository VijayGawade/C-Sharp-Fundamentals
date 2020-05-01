using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class C_Looping
    {
        internal static void WhileLoop()
        {
            int cnt = 1;
            while (cnt < 6)
                Console.WriteLine("Value of Counter is " + cnt++);
        }

        internal static void ForLoop()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello World !");
        }

        internal static void DoWhileloop()
        {
            int input,totalSum=0;
            do
            {
                Console.Write("Enter number or -1 to quit: ");
                input = int.Parse(Console.ReadLine());
                totalSum += input;
            } while (input != -1);
            Console.WriteLine("Total Sum of entered numbers is " + totalSum);
        }

        internal static void NestedLoop()
        {
            do
            {
                Console.Write("Enter Height of Pyramind or -1 to quit: ");
                int height = int.Parse(Console.ReadLine());

                if (height == -1) break;

                for (int row = 0; row < height; row++)
                {
                    for (int col = row; col < height; col++)
                        Console.Write("  ");
                    for (int col = 0; col <= row*2; col++) 
                        Console.Write("* ");
                    Console.WriteLine();
                }

            } while (true);
        }

        internal static void Exercise1_GetValidPayRate()
        {
            double rate;
            do
            {
                Console.Write("Enter hourly pay rate($5.65-$49.99):");
                rate = double.Parse(Console.ReadLine());
            } while (rate < 5.65 || rate > 49.99);
            Console.WriteLine("valid enterd Rate is " + rate);
        }

        internal static void Exercise2_SumOf1_50()
        {
            int sum = 0;
            for (int num = 1; num <= 50; num++)
                sum += num;
            Console.WriteLine("Sum of 1 to 50 is " + sum);
        }

        internal static void Exercise3_GuessRandomNumber()
        {
            int randomNumber = new Random().Next(1, 11);
            int userGuessNumber = 0,cnt=0;
            do
            {
                Console.Write("Guess System-Generated Random Number(1-10): ");
                userGuessNumber = int.Parse(Console.ReadLine());
                cnt++;

                if (userGuessNumber > randomNumber)
                    Console.WriteLine("Your Guess is too high");
                else if (userGuessNumber < randomNumber)
                    Console.WriteLine("Your Guess is too low");
            } while (userGuessNumber != randomNumber);

            Console.WriteLine("Congratulations !  You guess correctly in {0} trials",cnt);
        }
    }
}
