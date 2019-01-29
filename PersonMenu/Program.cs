using System;
using System.Collections.Generic;

namespace PersonMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person ulf = new Person();
            ulf.FirstName = "Ulf";
            ulf.lastName = "Bengtsson";
            ulf.SayHello();

            Person erik = new Person("Erik", "Svensson");   // Smart way to use a Constructor(Overload) to simplefie our work.11
            erik.SayHello();
            */


            List<Person> people = new List<Person>();
            people.Add(new Person("Ulf", "Bengtsson")); // Adds ulf to the list of people, we dont need to create a verible first and then store it in the list.
            people.Add(new Person("Erik", "Svensson"));
            people.Add(new Person("Niklas","Yngvesson"));
            people.ForEach(p => p.SayHello());

            Console.ReadKey();
        }
    }
}
