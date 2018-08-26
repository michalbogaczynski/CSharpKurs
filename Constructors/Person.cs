using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        // konstruktor bez parametrów, inicjalizujemy je wartościami domyślnymi
        public Person()
        {
            id = 1;
            firstName = "Marcin";
            lastName = "Kowal";
            age = 14;
        }

        //przekazujemy parametry w celu inicjalizacji naszych pól
        public Person(int id, string firstName, string lastName, string address, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            address = "Katowice";
            age = 18;
        }

        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
