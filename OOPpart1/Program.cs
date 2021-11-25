using System;

namespace OOPpart1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created");
            }

            public string Name
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-Woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void WagTail()
            {
                Console.WriteLine("Wiggle-Wiggle");               
            }

            public void Rename(string newName)
            {
                name = newName;
            }
        }
        static void Main(string[] args)
        {
            Dog MyDog = new Dog("Koer", 15);
            //MyDog.happiness = 10;
            //MyDog.name = "Koer1";

            while (MyDog.Happiness != 1)
            {
                MyDog.Barks();
            }
            MyDog.WagTail();

            Console.WriteLine("Rename your dog");
            string userinput = Console.ReadLine();
            MyDog.Rename(userinput);
            
            Console.WriteLine($"{MyDog.Name}");
            Console.WriteLine($"Level of happiness: {MyDog.Happiness}");
        }
    }
}
