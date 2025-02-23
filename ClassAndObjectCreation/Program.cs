using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Toyota", "Corolla", 2020);
            car1.displayInfo();
        }
    }

    class Car {
        private string brand;
        private string model;
        private int year;

        public Car(string brand, string model, int year) {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void displayInfo() {
            Console.WriteLine($"Brand: {brand} Model: {model} Year: {year}");
        }
    }
}