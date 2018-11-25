using BasicConcepts.Classes;
using BasicConcepts.Objects;
using System;

namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is basic class createion, assigning and retreiving values
            Customer customer = new Customer();
            customer.firstName = "Test";
            customer.CustomerId = 1234;
            customer.LastName = "LastName";
            customer.Location = "India";
            Console.WriteLine("FirstName is :" + customer.firstName);
            Console.WriteLine("LastName is :" + customer.LastName);
            Console.WriteLine("Location is :" + customer.Location);
            Console.WriteLine("Customer id  is :" + customer.CustomerId);          
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.BaseMethod();
            Console.ReadLine();

        }
    }
}
