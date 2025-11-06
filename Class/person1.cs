using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Person1
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, My name is " + firstName + " " + lastName);
        }
    }
}
