using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5.EsercizioPratico
{
    class Person
    {
        //Persona
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CF { get; set; }

        public Person(string firstName, string lastName, string cf)
        {
            FirstName = firstName;
            LastName = lastName;
            CF = cf;
        }

        public Person()
        {

        }

    }
}
