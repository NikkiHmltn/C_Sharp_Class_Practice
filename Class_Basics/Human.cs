using System;
namespace Class_Basics
{
     class Human
    {
        

        // member variable
        public string firstName;
        public string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // "this" allows to reach out of the method and grab global variables
            this.lastName = lastName;
            this.firstName = firstName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I'm {3} years old.", firstName, lastName, eyeColor, age);
        }


    }
}
