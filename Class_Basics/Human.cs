using System;
namespace Class_Basics
{
     class Human
    {
        // create a public variable lasName of type string
        //change the Introduction method to call the whole name
        // create two objects with full information about themself - first and last name

        // member variable
        public string firstName;
        public string lastName;

        // constructor
        public Human(string firstName, string lastName)
        {
            // "this" allows to reach out of the method and grab global variables
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }


    }
}
