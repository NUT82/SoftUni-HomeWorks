﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 20;

            Person personTwo = new Person();
            personTwo.Name = "Gosho";
            personTwo.Age = 18;

            Person personThree = new Person();
            personThree.Name = "Stamat";
            personThree.Age = 43;
        }
    }
}
