using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class Student2
    {
        private string name;
        
        // Default Implementation of Property: No Private Data behind
        public int Age { get; set; }


        // Custom Implementation of Get & Set : Private Data/Member
        public string Name
        {
            get
            {
                if (Age < 18)
                    return "Student is young";
                else
                    return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }
        // Make only Get public
        public string Address { get; private set; }

        public Student2(string name,int age,string address)
        {
            this.name = name;
            this.Age = age;
            this.Address = address;
        }
    }
}
