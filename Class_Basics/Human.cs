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

        // member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }


    }
}
