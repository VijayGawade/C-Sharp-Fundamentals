using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class F_Classes
    {
        public void CallDifferentConstructors()
        {
            Student s0 = new Student();
            s0.SayHello();

            Student s1 = new Student("Vijay Gawade", 23, 99);
            s1.SayHello();

            Student s2 = new Student("Raju", 32);
            s2.SayHello();
        }

        public void GetSetMethods()
        {
            Student s1 = new Student("Vijay Gawade", 23, 99);
            s1.SayHello();
            s1.SetName("");
            s1.SayHello();
            s1.SetName("Vijay R. Gawade");
            s1.SayHello();
            Console.WriteLine("S1 Name is " + s1.GetName());            
        }

        public void Properties()
        {
            Student2 stud = new Student2("Vijay Gawade", 23, "Pune");
            stud.Age = 24;
            stud.Name = "Vijay R. Gawade";
            stud.Name = "";

            Console.WriteLine("Student Info:");
            Console.WriteLine("Name: " + stud.Name);
            Console.WriteLine("Age: " + stud.Age);
            Console.WriteLine("Address: " + stud.Address);
        }

        public void OperatorOverloading()
        {
            BankAccount b1 = new BankAccount("Ramchandra", 5000);
            BankAccount b2 = new BankAccount("Reshma " , 15200.5);

            BankAccount jointBankAccount = b1 + b2;
            Console.WriteLine("Joint Bank Account:  owner={0}\t balance={1}", jointBankAccount.Ower, jointBankAccount.Amount);
        }

        public void PassingObjectsToMethods()
        {
            Student2 student = new Student2("Vijay Gawade", 22, "Matond");
            Console.WriteLine("Before:\t\tName:{0}\tAge:{1}\tAddress:{2}", student.Name, student.Age, student.Address);
            // Note Class Object always pass by Refference, so any change in obj into method will reflect here also
            // When you pass an object to a method, the object is passed by reference
            IncrementStudentAge(student);
            Console.WriteLine("After:\t\tName:{0}\tAge:{1}\tAddress:{2}", student.Name, student.Age, student.Address);
        }

        void IncrementStudentAge(Student2 student,int age=1)
        {
            student.Age+=age;
        }

        public void ArrayOfObjects()
        {
            Person[] familyMembers = new Person[3];
            familyMembers[0] = new Person("Vijay Gawade", 23);
            familyMembers[1] = new Person("Ramchandra Gawade", 56);
            familyMembers[2] = new Person("Reshma Gawade", 44);

            Console.WriteLine("Family Details:");
            for (int i = 0; i < 3; i++)
                Console.WriteLine("\tName:{0,-20}\tAge:{1,-3}", familyMembers[i].Name, familyMembers[i].Age);

            Person[] neineighbourFamily = new Person[2];
            neineighbourFamily[0] = new Person("keshav Gawade", 24);
            neineighbourFamily[1] = new Person("Dropadi Gawade", 49);

            Console.WriteLine("Total Population is " + Person.Count);
        }

        public void Exercise1_CalculateSquareArea()
        {
            Square[] squares = new Square[10];

            for(int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("Square {0,-2}  with Length={1} and Area={2}", (i + 1), squares[i].Side, squares[i].Area);
            }
        }

        public void Exercise2_CalculateTax()
        {
            int totalTaxPayers = 1;
            TaxPayer[] taxPayers = new TaxPayer[totalTaxPayers];

            for (int i = 0; i < totalTaxPayers; i++)
            {
                Console.WriteLine("\nFor Person " + (i+1));
                Console.Write("Enter SSN: ");
                string ssn = Console.ReadLine();
                Console.Write("Enter Income: ");
                double income = double.Parse(Console.ReadLine());
                taxPayers[i] = new TaxPayer(ssn,income);                
            }

            Console.WriteLine("\nAll Taxpayer Details:");
            for(int i = 0; i < totalTaxPayers; i++)
            {
                Console.WriteLine("SSN:{0}\tIncome:{1}\tTax Owned:{2}.", taxPayers[i].SocialSecurityNumber, taxPayers[i].YearlyGrossIncome, taxPayers[i].TaxOwed);
            }
        }

        public void Exercise3_JobFeeCalculator()
        {
            Job j1 = new Job("washing windows", 3, 5);
            Console.WriteLine("For Job '{0}' with Time req={1} Hrs and Hourly Rate=$ {2}  have Total Fee={3}.",
                                    j1.JobDesc,j1.TimeToComplete,j1.HourlyRate,j1.TotalFee);
            Job j2 = new Job("take out trash",1, 10);
            Console.WriteLine("For Job '{0}' with Time req={1} Hrs and Hourly Rate=$ {2}  have Total Fee={3}.",
                                    j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);
            Job j3 = j1 + j2;
            Console.WriteLine("For Job '{0}' with Time req={1} Hrs and Hourly Rate=$ {2}  have Total Fee={3}.",
                                    j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);
        }
    }

}
