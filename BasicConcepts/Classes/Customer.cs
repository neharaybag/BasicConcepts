using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts.Objects
{
    class Customer
    {
        private int customerId;
        public string firstName; //public varibale can be accessed without get set
        private string lastName;
        private string location;
        

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }


    }


}
