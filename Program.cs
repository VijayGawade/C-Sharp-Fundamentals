using System;

namespace C_Sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int section = 5;

            switch (section)
            {
                case 5:
                    E_Methods obj = new E_Methods();
                    obj.CreatingMethods();
                    break;
                case 4:
                    D_UsingsArrays.CreatingArray();
                    D_UsingsArrays.ArrayMethods();
                    D_UsingsArrays.MultiDimensionalArray();
                    D_UsingsArrays.Exercise1_PackageDeliveryService();
                    D_UsingsArrays.Exercise2_ClassResult();
                    break;
                case 3:
                    C_Looping.WhileLoop();
                    C_Looping.ForLoop();
                    C_Looping.DoWhileloop();
                    C_Looping.NestedLoop();
                    C_Looping.Exercise1_GetValidPayRate();
                    C_Looping.Exercise2_SumOf1_50();
                    C_Looping.Exercise3_GuessRandomNumber();
                    break;
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
