using System;
using JetBrains.Annotations;

namespace RC3_Dog
{
    public class Dog
    {
        //variables
        string name;
        string breed;
        int age;

        //constructor
        public Dog(string _name, string _breed, int _age)
        {
            name = _name;
            breed = _breed;
            age = _age;
        }

        //functions
        public string GetName()
        {
            return name;
        }

        public string GetBreed()
        {
            return breed;
        }

        public int GetAge()
        {
            return age;
        }
    }
}

