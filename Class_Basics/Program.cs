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
            anna.firstName = "Anna";
            anna.Introduction();
        }
    }
}
