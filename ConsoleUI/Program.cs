using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel();
            person.FirstName = "Bob";
            person.LastName = "Smith";


            double rez = Calculation.Add(7, 3);
            Console.WriteLine(rez);
            Console.WriteLine(person.FirstName);
            Console.ReadLine();
        }
    }
}


    //From this point on, only place code for user interface in Program.cs
    //Everything else should go into a class library

    //Pro-Tip: 

    //Homework: 