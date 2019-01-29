using System;
using System.Collections.Generic;
using System.Text;

namespace PersonMenu
{
    class Person
    {
        public string FirstName { get; set; }
        public string lastName;
        int age;

        public Person(){}   // Zero Constructor - If we don´t create any constructor then C# compiler will add this one for ous.

        public Person(string firstName, string lastName)    // When we Overload a Constructor or Method, it the input types that are the key for the computer to see the diffrence between them(not the verible name).
        {
            FirstName = firstName;
            this.lastName = lastName;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello! My name is " + FirstName + " " + lastName);
        }
    }
}
