using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts.Objects
{
    class Customer
    {
        private int _customerId;
        public string firstName; //public varibale can be accessed without get set
        private string _lastName;
        private string _location;
        

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }


    }


}
