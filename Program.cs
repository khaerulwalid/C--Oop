using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Person person1 = new Person("John", 25);
            Person person2 = new Person("John", 25, "USA");

            person1.DisplayInfo();
            person2.DisplayInfo();
        }
    }

    class Person {
        public string Name {
            get; private set;
        }
        private int Age {
            get; set;
        }
        private string Address {
            get; set;
        }
        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
            this.Address = "Unknow";
        }

        public Person(string name, int age, string address) : this(name, age) {
            this.Address = address;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
}