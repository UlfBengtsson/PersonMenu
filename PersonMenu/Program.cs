using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;

namespace PersonMenu
{
    class Program
    {
        static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            /**
            Person ulf = new Person();
            ulf.FirstName = "Ulf";
            ulf.lastName = "Bengtsson";
            //ulf.age = 99;
            ulf.SayHello();
            
            Person erik = new Person("Erik", "Svensson");   // Smart way to use a Constructor(Overload) to simplefie our work.11
            erik.SayHello();

            people.Add(new Person("Ulf", "Bengtsson", 37)); // Adds ulf to the list of people, we dont need to create a verible first and then store it in the list.
            people.Add(new Person("Erik", "Svensson", 39));
            people.Add(new Person("Niklas", "Yngvesson"));

            people.Add( CreatePerson() );

            people.ForEach(p => p.SayHello());
            */

            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine(
                    "--- People menu ---\n" +
                    "1: Add Person to list\n" +
                    "2: Show list\n" +
                    "3: Add Random Person to list\n" +
                    "4: Remove Person from list\n" +
                    "0: Exit program"
                    );
                int selection = AskUserForNumberX("Select");

                switch (selection)
                {
                    case 1:
                        people.Add(CreatePerson());
                        break;
                    case 2:
                        PrintList(people);
                        break;
                    case 3:
                        people.Add( CreateRandomPerson() );
                        break;
                    case 4:
                        RemovePersonFromList(people);
                        break;
                    case 0:
                        keepAlive = false;
                        Console.WriteLine("Thanks for using this program!");
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);// Dose not print key to screen
                Console.Clear();
            }


        }

        static void RemovePersonFromList(List<Person> people)
        {
            bool notFound = true;

            Console.WriteLine("--- Remove person ---" );
            PrintList(people);
            int selected = AskUserForNumberX("number of person");

            foreach (Person item in people)
            {
                if (item.Id == selected)
                {
                    people.Remove(item);
                    notFound = false;
                    break;
                }
            }

            if (notFound)
            {
                Console.WriteLine("No Person with that number was found.");
            }
            else
            {
                Console.WriteLine("Person with Id: " + selected + " has bin removed.");
            }
        }

        private static Person CreateRandomPerson()
        {
            return new Person( 
                infoGen.NextFirstName(), 
                infoGen.NextLastName(), 
                infoGen.Next(1,120));//Age 1-120
        }

        static void PrintList(List<Person> people)
        {
            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }
            //people.ForEach(p => p.SayHello());
        }

        static Person CreatePerson()
        {
            string firstName = AskUserForX("First name");
            string lastName = AskUserForX("last name");
            int age = AskUserForNumberX("Age");

            return new Person(firstName, lastName, age);
        }// CreatePerson ends

        static string AskUserForX(string x)
        {
            string input = "";

            while (input.Length == 0)
            {
                Console.Write("Pleace input " + x + ": ");
                input = Console.ReadLine();
            }

            return input;
        }

        static int AskUserForNumberX(string x)
        {
            int number = 0;
            bool noNumber = true;

            while (noNumber)
            {
                try
                {
                    number = Convert.ToInt32(AskUserForX(x));
                    noNumber = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number, Pleace try once more.");
                }
            }

            return number;
        }
    }
}
