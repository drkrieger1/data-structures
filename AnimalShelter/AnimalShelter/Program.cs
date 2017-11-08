using System;
using System.Collections.Generic;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelter myShelter = new Shelter();
            Console.WriteLine("Welcome to the Animal shelter");
            string[] AnimalContol = {"cat", "cat", "dog", "cat", "dog", "dog" };
            foreach(string animal in AnimalContol)
            {
                myShelter.Load(animal);
            }
            Animal dog = myShelter.Adopt("dog");
            Console.WriteLine($"adopting a {dog.Type} : {dog.Arival}");
            Animal cat = myShelter.Adopt("cat");
            Console.WriteLine($"adopting a {cat.Type} : {cat.Arival}");
            Animal any = myShelter.Adopt("any");
            Console.WriteLine($"adopting a {any.Type} : {cat.Arival}");
            Console.Read();
        }
    }
    class Animal
    {
        public string Type { get; set; }
        public int Arival { get; set; }

        public Animal(string type, int arival)
        {
            Type = type;
            Arival = arival;
        }
    }
    class Shelter
    {
        int animalTotal = 1;
        Queue<Animal> Cat = new Queue<Animal>();
        Queue<Animal> Dog = new Queue<Animal>();

        public void Load(string type)
        {
            if(type.ToLower() == "cat")
            {
                Cat.Enqueue(new Animal(type, animalTotal));
                animalTotal++;
            } else
            {
                Dog.Enqueue(new Animal(type, animalTotal));
                animalTotal++;
            }
            //animalTotal++;        
        }
        public Animal Adopt(string input)
        {
            if(input.ToLower() == "cat")
            {
                return Cat.Dequeue();
            }
            if (input.ToLower() == "dog")
            {
                return Dog.Dequeue();
            }else
            {
                if(Cat.Peek().Arival < Dog.Peek().Arival)
                {
                    return Cat.Dequeue();
                } else
                {
                    return Dog.Dequeue();
                }
            }
        }

    }
}
