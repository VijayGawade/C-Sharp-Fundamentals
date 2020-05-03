using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class Student
    {
        private string name;
        private int age;
        private double finalScore;

        // Default Constructor
        public Student()
        {
            name = "Dummy Student";
            age = 30;
            finalScore = 0;
        }

        // Parameter Constructor
        public Student(string name,int age,double finalScore)
        {
            this.name = name;
            this.age = age;
            this.finalScore = finalScore;
        }

        // Constructor Overloading 
        public Student(string name,int age) : this(name, age, 0) // call param Constructor to avoid code duplication
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello {0} !...", name);
        }

        public string GetName()
        {
            if (age >= 18)
                return name;
            else
                return "Student is young";
        }

        public void SetName(string name)
        {
            if (name != "")
                this.name = name;
        }
    }
}
