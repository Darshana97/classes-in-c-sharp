using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{

    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
           this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void FullName()
        {
            Console.WriteLine("My name is {0}",this._firstName + " " + this._lastName);
            Console.ReadLine();
        }

        ~Customer()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Darshana","Senevirathna");
            c1.FullName();
        }
    }
}
