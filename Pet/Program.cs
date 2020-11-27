﻿using System;

namespace Pet
{
    class Pet
    {
        string name;
        int age;
        double weight;
        int lifespan;
        
        public Pet(string _name, double _weight)
        {
            name = _name;
            weight = _weight;
        }
        public int Lifespan
        {
            get { return lifespan; }
        }
        public double Weight
        {
            get { return weight; }
        }
        public double Age
        {
            get { return age; }
        }
        public void Eat()
        {
            Console.WriteLine("DEBUG: Eat routine");
            Console.WriteLine("DEBUG: Weight before: " + weight);
            weight += 0.2;
            Console.WriteLine("DEBUG: Weight after: " +weight);
        }
        public void Exercise()
        {
            Console.WriteLine("DEBUG: Exercise routine");
            Console.WriteLine("DEBUG: Weight before: " + weight);
            weight -= 0.1;
            Console.WriteLine("DEBUG: Weight after: " + weight);
        }
        public void InfoDisplay()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Lifespan: " + lifespan);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet newHamster = new Pet("Luud", 0.01);

            for (int age = 0; age < 10; age++)
            {
                if (newHamster.Weight > 0.7)
                {
                    newHamster.Exercise();
                }
               else if (newHamster.Weight < 0.7)
                {
                    newHamster.Eat();
                }
                Console.WriteLine("Iteration: " + age);
            }
        }
    }
}
