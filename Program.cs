using System;

namespace C_Sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int section = 2;

            switch (section)
            {
                case 2:
                    B_MakingDecisions.If_ElseIf_Else_Statement();
                    B_MakingDecisions.Swich_Statement();
                    B_MakingDecisions.ConditionalNotOperator();
                    B_MakingDecisions.Exercise1_CheckValidRate();
                    B_MakingDecisions.Exercise2_LawnMovingService();
                    B_MakingDecisions.Exercise3_GuessRandomNumber();
                    break;
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
