using System;

namespace MoreObjectOrientation
{
    interface ILivingCreature
    {
        public abstract void Die();
    }

    abstract class Animal
    {
        public abstract void MakeNoise();
    }
    class Dog : Animal, ILivingCreature
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Hau hau");
        }
        public void Die()
        {
            Console.WriteLine("A sad day... dog dies...");
        }
    }
    class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Miau miau");
        }
    }

    class Monkey : Animal 
    {
        public override void MakeNoise()
        {
            Console.WriteLine("UU aa");
        }
    }


    class Human : ILivingCreature
    {
        public void Die()
        {
            Console.WriteLine("Person dies... what a sorrow...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Dog(), new Cat(), new Monkey() };
            MakeNoises(animals);

            ILivingCreature[] creaturesToKill = { new Dog(), new Human() };
            Kill(creaturesToKill);
            //Dog d = new Dog();
            //d.MakeNoise();

            //Cat c = new Cat();
            //c.MakeNoise();
        }

        static void MakeNoises(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
            }
        }
        static void Kill(ILivingCreature[] livingCreatures)
        {
            foreach (var livingCreature in livingCreatures)
            {
                livingCreature.Die();
            }
        }
    }
}
