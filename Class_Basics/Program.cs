using System;

namespace Class_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of the class human
            // an "instance" of Human
            Human anna = new Human("Anna","Wagner", "blue", 24);
            
            
            // call methods of the class
            anna.Introduction();

            Human michael = new Human("Michael","Smith", "brown", 37);
            michael.Introduction();
        }
    }
}
