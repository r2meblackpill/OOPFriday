using System;

namespace OOPFriday
{
    class Cat
    {
        string name;
        string color;
        double hunger;

        public Cat (string _name, string _color)
        {
            name = _name;
            color = _color;
            hunger = 1;
        }
        public string Name
        {
            get { return name; }
        }
        public string Color
        {
            get { return color; }
        }
        public double Hunger
        {
            get { return hunger; }
        }
        public void Meow()
        {
            Console.WriteLine("meow");
        }
        public void Sleep()
        {
            Console.WriteLine("The cat is sleeping.");
            hunger -= 0.1;
            Console.WriteLine("DEBUG: Hunger: " + hunger);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Miisu", "Black and white");

            Console.WriteLine(newCat.Hunger);
            while (newCat.Hunger !> 0)
            {
                newCat.Sleep();
            }
        }

    }
}
