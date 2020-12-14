using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {
            return person.City == "Manchester";
            
        }

        public static bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age >= ageLimit;
            
        }
    }
    public class Person
    {
        public Person(string username, string lastname, string city, int age)
        {
            FirstName = username;
            LastName = lastname;
            City = city;
            Age = age;
        }

        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }

        public string City
        { get; set; }
        public int Age
        { get; set; }

    }
}