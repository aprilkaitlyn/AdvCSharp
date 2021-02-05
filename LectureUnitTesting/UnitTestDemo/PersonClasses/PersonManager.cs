using System;
using System.Collections.Generic;

namespace UnitTestDemo.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {

            Person ret = null;

            if (!string.IsNullOrEmpty(first)) //if no first name, object will not be created
            {
                if (isSupervisor)
                {
                    ret = new Supervisor(); //create a supervisor
                }
            }
            else { ret = new Employee(); } //if not a supervisor, create an employee

            //assign variable
            ret.FirstName = first;
            ret.LastName = last;

            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Kaitlyn", LastName = "Heishman" });
            people.Add(new Person() { FirstName = "Christina", LastName = "Deken" });
            people.Add(new Person() { FirstName = "Kylee", LastName = "Bee" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Dahyun", "Kim", true));
            people.Add(CreatePerson("Momo", "Hirai", true));
            people.Add(CreatePerson("Jeongyeon", "Yoo", true));

            return people;
        }
    }
}
