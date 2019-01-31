using System;
using System.Collections.Generic;
using System.Text;

namespace PersonMenu
{
    class Person
    {
        static int countId = 0;

        public int Id { get; private set; }

        public string FirstName { get; set; }
        public string lastName;
        public string FullName { get { return FirstName + " " + lastName; } }
        int age;
        public int Age {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age can´t be Zero or lower");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Person() { }   // Zero Constructor - If we don´t create any constructor then C# compiler will add this one for ous.

        public Person(string firstName, string lastName)    // When we Overload a Constructor or Method, it the input types that are the key for the computer to see the diffrence between them(not the verible name).
        {
            Id = ++countId;
            FirstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.age = age;
        }

        public void SayHello()
        {
            Console.Write("Hello! My name is " + FullName);

            if (age > 0)
            {
                Console.Write(" im " + age + " years old");
            }

            Console.WriteLine();
        }

        override public string ToString()
        {
            return Id + ": " + FullName;
        }
    }
}
