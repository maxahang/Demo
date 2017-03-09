using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    class Animal
    {
        protected string Name;
        public Animal()
        {
            Name = "Unknow";
        }
        public virtual void Say()
        {
            Console.WriteLine("What does the " + Name + " say:");
            if ("Unknow" == Name)
            {
                Console.WriteLine("......");
            }
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Name = "Dog";
        }
        
        public override void Say()
        {
            base.Say();
            Console.WriteLine("Woof Woof Woof~");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            Name = "Cat";
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("Meow Meow Meow~");
        }
    }

    class Fox : Animal
    {
        public Fox()
        {
            Name = "Fox";
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("Ring ding ding ding~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listAnimal = new List<Animal>();
            listAnimal.Add(new Dog());
            listAnimal.Add(new Cat());
            listAnimal.Add(new Fox());

            foreach(var item in listAnimal)
            {
                item.Say();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
