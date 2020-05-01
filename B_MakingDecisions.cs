using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class B_MakingDecisions
    {
        internal static void If_ElseIf_Else_Statement()
        {
            // IF-Elseif-Else
            int age = 22;
            if (age > 70)
                Console.WriteLine("Sorry ! Age limit exceeded ....");
            else if (age > 18)
            {
                Console.WriteLine("You are good to go !...");
                // Nested IF-Else
                if (age < 45)
                    Console.WriteLine("Your Grade is A.");
                else
                    Console.WriteLine("Your Grade is B.");
            }
            else
                Console.WriteLine("You are under age !");

            //  Compound statement in If Statement
            if (age >= 18 && age <= 70)
                Console.WriteLine("You are eligible ..");
            else if (age < 18 || age > 71)
                Console.WriteLine("Sorry ! you are not eligible ...");
            // NOTE: && have high Precedence than || 
        }

        internal static void Swich_Statement()
        {
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                // Multiple cases
                case 0:
                case 1:
                    Console.WriteLine("Day is Sunday.");
                    break;
                case 2:
                    Console.WriteLine("Day is Monday.");
                    break;
                case 3:
                    Console.WriteLine("Day is Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("Day is Wedensday.");
                    break;
                case 5:
                    Console.WriteLine("Day is Thursday.");
                    break;
                case 6:
                    Console.WriteLine("Day is Friday.");
                    break;
                case 7:
                    Console.WriteLine("Day is Saturday.");
                    break;
            }
        }

        internal static void ConditionalNotOperator()
        {
            int x = 4, y = 9;

            Console.WriteLine("Greater number from {0} and {1} is {2}",x,y,(x>y)?x:y);
        }

        internal static void Exercise1_CheckValidRate()
        {
            Console.Write("Enter hourly pay rate: ");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            if (hourlyPayRate < 7.5 || hourlyPayRate > 49)
                Console.WriteLine("Rate is incorrect.");
            else
                Console.WriteLine("Rate is correct.");
        }

        internal static void Exercise2_LawnMovingService()
        {
            Console.Write("Enter Length of Lawn: ");
            double lawnLength = double.Parse(Console.ReadLine());
            Console.Write("Enter Width of Lawn: ");
            double lawnWidth = double.Parse(Console.ReadLine());

            double area = lawnLength * lawnWidth;
            double weeklyPrice;
            if (area < 400)
                weeklyPrice = 25;
            else if (area >= 400 && area < 600)
                weeklyPrice = 35;
            else
                weeklyPrice = 50;

            Console.WriteLine("Your weekly mowing fee is " + weeklyPrice);
            Console.WriteLine("Total Fee for 20 week session is " +weeklyPrice*20);
        }

        internal static void Exercise3_GuessRandomNumber()
        {
            int randomNumber = new Random().Next(1, 100);
            Console.Write("Guess the Random Number (1,100): ");
            int userGuessNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Random Number was " + randomNumber);
            if (userGuessNumber > randomNumber)
                Console.WriteLine("Your Guess is too high");
            else if (userGuessNumber == randomNumber)
                Console.WriteLine("Congratulations !  You guess correctly ");
            else
                Console.WriteLine("Your Guess is too low");
        }
    }
}
