using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(5, 4);

            // Memanggil metode Area() pada masing-masing objek
            Console.WriteLine($"Luas Lingkaran: {circle.Area()}");
            Console.WriteLine($"Luas Persegi Panjang: {rectangle.Area()}");
        }
    }

    abstract class Shape {
        public abstract double Area();
    }

    class Circle : Shape {
        private double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override double Area() {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape {
        private double width;
        private double height;

        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }

        public override double Area() {
            return width * height;
        }
    }
}