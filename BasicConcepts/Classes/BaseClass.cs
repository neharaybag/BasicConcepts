using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts.Classes
{
    public class BaseClass
    {
        private int value = 20;

        public void BaseMethod()
        {
            Console.WriteLine("Hello from base class");
            Console.WriteLine("Value" + value);
        }
        
    }
}
