using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class City
    {
        private readonly List<Person> _people;

        public City()
        {
            this._people = new List<Person>();
        }

        public void AddCitizen(Person person)
        {
            this._people.Add(person);
        }

        public void GetFull()
        {
            foreach (var person in this._people)
            {
                Console.WriteLine(person.GetInfo() + ":" + person.GetName() + " | " + person.GetAge());
            }
        }
    }
}