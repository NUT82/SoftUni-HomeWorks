using System;
using System.Collections.Generic;
using WildFarm.Contracts;
using WildFarm.Creators;
using WildFarm.Creators.Animals;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            

            string command = Console.ReadLine();

            while (command != "End")
            {
                AnimalCreator animalCreator = null;
                FoodCreator foodCreator = null;

                string[] animalInput = command.Split();
                string animalType = animalInput[0];
                string name = animalInput[1];
                double weight = double.Parse(animalInput[2]);

                switch (animalType)
                {
                    case "Hen":
                        double wingSize = double.Parse(animalInput[3]);
                        animalCreator = new HenCreator(name, weight, wingSize);
                        break;
                    case "Owl":
                        wingSize = double.Parse(animalInput[3]);
                        animalCreator = new OwlCreator(name, weight, wingSize);
                        break;
                    case "Mouse":
                        string livingRegion = animalInput[3];
                        animalCreator = new MouseCreator(name, weight, livingRegion);
                        break;
                    case "Cat":
                        livingRegion = animalInput[3];
                        string breed = animalInput[4];
                        animalCreator = new CatCreator(name, weight, livingRegion, breed);
                        break;
                    case "Dog":
                        livingRegion = animalInput[3];
                        animalCreator = new DogCreator(name, weight, livingRegion);
                        break;
                    case "Tiger":
                        livingRegion = animalInput[3];
                        breed = animalInput[4];
                        animalCreator = new TigerCreator(name, weight, livingRegion, breed);
                        break;
                }

                string[] foodInput = Console.ReadLine().Split();
                string foodType = foodInput[0];
                int quantity = int.Parse(foodInput[1]);

                switch (foodType)
                {
                    case "Vegetable":
                        foodCreator = new VegetableCreator(quantity);
                        break;
                    case "Fruit":
                        foodCreator = new FruitCreator(quantity);
                        break;
                    case "Meat":
                        foodCreator = new MeatCreator(quantity);
                        break;
                    case "Seeds":
                        foodCreator = new SeedsCreator(quantity);
                        break;
                }

                Animal animal = animalCreator.CreateAnimal();
                Food food = foodCreator.CreateFood();

                Console.WriteLine(animal.AskForFood());
                try
                {
                    animal.Feed(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
    }
}
