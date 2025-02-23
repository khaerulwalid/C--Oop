using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.makeSound();
            dog.makeSound();
            cat.makeSound();
        }
    }

    class Animal {
        public virtual void makeSound() {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal {
        public override void makeSound() {
            Console.WriteLine("Gong gong");
        }
    }

    class Cat : Animal {
        public override void makeSound() {
            Console.WriteLine("Meow meow");
        }
    }
}