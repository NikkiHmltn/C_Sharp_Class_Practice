using System;

namespace Class_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of the class human
            // an "instance" of Human
            Human anna = new Human();
            // access public variable form outside, and change it
            anna.firstName = "Anna";
            anna.lastName = "Bell";
            // call methods of the class
            anna.Introduction();

            Human michael = new Human();
            michael.firstName = "Michael";
            michael.lastName = "Smith";
            michael.Introduction();
        }
    }
}
