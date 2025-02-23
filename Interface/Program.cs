using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            IFlyable sparrow = new Bird();
            IFlyable boeing747 = new AirPlane();

            sparrow.Fly();
            boeing747.Fly();
        }
    }

    interface IFlyable {
        void Fly();
    }

    class Bird: IFlyable {
        public void Fly() {
            Console.WriteLine("Burung terbang dengan mengepakkan sayap.");
        }
    }

    class AirPlane : IFlyable {
        public void Fly() {
            Console.WriteLine("Pesawat terbang dengan mesin.");
        }
    }
}