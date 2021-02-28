using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string typeOfAnimal = Console.ReadLine();
            while (typeOfAnimal != "Beast!")
            {
                string[] currAnimal = Console.ReadLine().Split();
                string name = currAnimal[0];
                int age = int.Parse(currAnimal[1]);
                string gender = currAnimal[2];

                if ((gender != "Male" && gender != "Female") || age < 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    switch (typeOfAnimal)
                    {
                        case "Cat":
                            if (name == "Tomcat")
                            {
                                Tomcat tomcat = new Tomcat(name, age, gender);
                                animals.Add(tomcat);
                            }
                            else if (name == "Kitten")
                            {
                                Kitten kitten = new Kitten(name, age, gender);
                                animals.Add(kitten);
                            }
                            else
                            {
                                Cat cat = new Cat(name, age, gender);
                                animals.Add(cat);
                            }
                            break;
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                typeOfAnimal = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
