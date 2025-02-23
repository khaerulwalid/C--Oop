using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Shape circle = new Circle(10);
            Shape rectangle = new Rectangle(6, 10);

            Console.WriteLine($"Luas Lingkaran: {circle.Area()}, Keliling: {circle.Perimeter()}");
            Console.WriteLine($"Luas Persegi Panjang: {rectangle.Area()}, Keliling: {rectangle.Perimeter()}");
        }
    }

    abstract class Shape {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape {
        private double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override double Area() {
            return Math.PI * radius * radius;
        }

        public override double Perimeter() {
            return 2 * Math.PI * radius;
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

        public override double Perimeter() {
            return 2 * (width + height);
        }
    }
}