using System;
using System.Collections.Generic;

namespace TasksPartOne
{
    namespace DiffCastings
    {
        static public class BuilderCar
        {
            public static string get_random_name()
            {
                List<string> names = new List<string>() { "Man", "Mercedes", "KAMAZ", "MAZ" };
                Random random = new Random();
                return names[random.Next(names.Count)];
            }
        }
        public class Car
        {
            protected int Power { get; set; }
            public int Cost { get; set; }
            protected string Name { get; set; }

            public Car(int power, int cost, string name)
            {
                Power = power;
                Cost = cost;
                Name = name;
            }

            public virtual string get_info()
            {
                return string.Format("{0} ({1}, {2}$)", Name, Power, Cost);
            }
        }

        public class Bus : Car
        {
            private int Seats { get; set; }

            public Bus(int power, int cost, int seats) : base(power, cost, BuilderCar.get_random_name())
            {
                Seats = seats;
            }
            public override string get_info()
            {
                return string.Format("{0} ({1}, {2}$, seats:{3})", 
                    Name,
                    Power.ToString(), 
                    Cost.ToString(),
                    Seats.ToString());
            }
        }

        public class Truck : Car
        {
            private int MaxWeight { get; set; }

            public Truck(int power, int cost, int weight) : base(power, cost, BuilderCar.get_random_name())
            {
                MaxWeight = weight;
            }
            public override string get_info()
            {
                return string.Format("{0} ({1}, {2}$, maxweight:{3}kg)",
                    Name,
                    Power.ToString(),
                    Cost.ToString(),
                    MaxWeight.ToString());
            }
        }
        public class A
        {
            public virtual void Foo()
            {
                Console.Write("Class A");
            }
        }
        public class B : A
        {
            public override void Foo()
            {
                Console.Write("Class B");
            }
        }
    }
}
