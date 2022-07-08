using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2211040#content
namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object initializer - a syntax for quickly initializing an object without
            // the need to call one of its constructors


            //with object initalization syntax:
            var person = new Person
            {
                FirstName = "Abe",
                LastName = "Cede",
            };
        }
    }
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;

        

        //without object initialization syntax:
        //public Person(int id)
        //{

        //}
        //public Person(int id, string firstName)
        //{

        //}
        //public Person(int id, string firstName, string lastName)
        //{

        //}
        //public Person(int id, DateTime birthdate)
        //{

        //}
    }
}