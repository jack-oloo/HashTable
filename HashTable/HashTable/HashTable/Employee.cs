using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAssignment
{
    class Employee
    {
        public string _firstName;
        public string _lastName;

        //creating null constructors - empty
        public Employee()
        {
            _firstName = "";
            _lastName = "";
        }

        //creating second constructors where users will pass on information
        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //properties 
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }

        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        //overrideing to see results
        public override string ToString()
        {
            return _firstName + "" + _lastName;
        }



    }
}
