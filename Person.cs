using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count;

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
            Count++;
        }
    }
}
