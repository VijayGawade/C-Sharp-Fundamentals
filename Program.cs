using System;

namespace C_Sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int section = 1;

            switch (section)
            {
                case 1:
                    A_UsingData.DeclareVariable();
                    A_UsingData.ArithmeticOperators();
                    A_UsingData.StringDataType();
                    A_UsingData.NumericConversion();
                    A_UsingData.DeclaringConstants();
                    A_UsingData.ReadConsoleInput();
                    A_UsingData.Exercise1_AddIntCalculator();
                    A_UsingData.Exercise2_CarpetCostCalculator();
                    A_UsingData.Exercise3_MinutesToHMConverter();
                    break;
                default:
                    Console.WriteLine("Invalid Section");
                    break;
            }
        }
    }
}
