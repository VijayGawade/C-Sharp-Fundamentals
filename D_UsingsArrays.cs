using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class D_UsingsArrays
    {
        internal static void CreatingArray()
        {
            // Raw array with default value 0
            int[] myArray = new int[3];

            // Creating array with size & assigning value to array
            int[] myArray2 = new int[3] { 1, 2, 3 };

            // Creating array, assigning values  & auto get Size
            int[] myArray3 = new int[] { 4, 5, 6 };

            // Without new Keyword
            int[] myArray4 = { 7, 8, 9 };

            // For each Loop
            foreach(int num in myArray4)
            {
                //num += 3;    // Cann't change value readonly field
                Console.WriteLine("Current Element: " + num);
            }       
        }

        internal static void ArrayMethods()
        {
            int[] myArray4 = { 7, 8, 9 };

            Console.WriteLine("myArray4 elements:");
            foreach (int num in myArray4)
                Console.WriteLine(num);

            // Binary Search
            int position = Array.BinarySearch(myArray4, 3);
            if (position < 0) Console.WriteLine("Number not found !...");
            else Console.WriteLine("Number at index " + position);

            // Sort Array()
            Array.Sort(myArray4);
            Console.WriteLine("Sort Array accending elements:");
            foreach (int num in myArray4)
                Console.WriteLine(num);

            // Reverse Array
            Array.Reverse(myArray4);
            Console.WriteLine("Reverse Array elements:");
            foreach (int num in myArray4)
                Console.WriteLine(num);
        }

        internal static void MultiDimensionalArray()
        {
            // Rectangle Array: same # of columns for each row
            int[,] myRectMdArray = new int[3, 3] {
                                                    {1,2,3},
                                                    {4,5,6 },
                                                    {7,8,9 }
                                                };
            myRectMdArray[0, 0] = 3;
            Console.WriteLine("Multi-Dimensinal Rectangle Array:");
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,-2}", myRectMdArray[i, j]);
                Console.WriteLine();
            }

            // Jagged Array: array of arrays, rows with different # 0f columns(elements)
            int[][] myJaggedArray = new int[3][];
            myJaggedArray[0] = new int[3] { 1, 2, 3 };
            myJaggedArray[1] = new int[5] { 4, 5, 6, 7, 8 };
            myJaggedArray[2] = new int[7] { 9,10,11,12,13,14,15 };
            
            Console.WriteLine("Jagged Array:");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                    Console.Write("{0,-3}",myJaggedArray[i][j]);
                Console.WriteLine();
            }
        }

        internal static void Exercise1_PackageDeliveryService()
        {
            string[] availableZipCode = { "416529", "416510", "411003", "411072", "123456", 
                                          "759425","658485","759643","689574","789926"};
            Console.Write("Enter zip-code:");
            string userZipCode = Console.ReadLine();

            bool isAvailable = false;
            foreach(string zipcode in availableZipCode)
            {
                if (userZipCode == zipcode)
                {
                    isAvailable = true;
                    break;
                }
            }

            if (isAvailable)
                Console.WriteLine("Company service available at ur zipcode");
            else
                Console.WriteLine("Sorry ! service is NOT available at ur zipcode...");
        }

        internal static void Exercise2_ClassResult()
        {
            Console.Write("Enter number of Student in Class: ");
            int totalStudent = int.Parse(Console.ReadLine());

            string[] sname = new string[totalStudent];
            double[] finalScore = new double[totalStudent];

            Console.WriteLine("Please provide Student Name & their final Score: ");
            for(int i = 0; i < totalStudent; i++)
            {
                Console.WriteLine("For Student " + (i + 1));
                Console.Write("Name: ");
                sname[i] = Console.ReadLine();
                Console.Write("Final Score: ");
                finalScore[i] = int.Parse(Console.ReadLine());
            }

            double maxGrade = 0, averageGragde = 0;
            foreach(double grade in finalScore)
            {
                if (maxGrade < grade) maxGrade = grade;
                averageGragde += grade;
            }
            averageGragde /= totalStudent;

            Console.WriteLine("Max Grage in Class is " + maxGrade);
            Console.WriteLine("Average Grade for Class is " + averageGragde);
        }

        internal static void Exercise3_HangmanGame()
        {
            string[] wordList = { "vijay", "gawade", "harman", "pendur", "pune", "dell", "ganesh", "issc" };
            string selectedWord = wordList[new Random().Next(wordList.Length)];

            string hiddenWord="";
            for (int i = 0; i < selectedWord.Length; i++)
                hiddenWord += "*";

            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Hidden Word: " +hiddenWord);
                Console.Write("Guess Letter: ");
                char guessChar = char.Parse(Console.ReadLine());
                bool isContains = false;
                for(int i = 0; i < selectedWord.Length; i++)
                {
                    if (guessChar == selectedWord[i])
                    {
                        hiddenWord.Remove(i, 1);
                        hiddenWord.Insert(i, guessChar.ToString());
                        isContains = false;
                    }
                }
                if (isContains)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                }
                Console.ResetColor();
            }
        }
    }
}
