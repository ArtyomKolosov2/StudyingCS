using System;
using System.Collections.Generic;
using System.Text;

namespace TasksPartTwo
{
    namespace StudyEvents
    {
        internal static class Builder
        {
            private static string[] Names { get; } =
            {
                "Opel",
                "Ford",
                "Lada",
                "Ferrari",
                "Volkswagen",
                "GM",
                "Fiat",
                "Mercedes",
                "Mitsubishi",
                "Volvo"
            };

            private static Random random = new Random();

            public static Car[] GetCars(int amount)
            {
                Car[] cars = new Car[amount];
                for (int i = 0; i < amount; i++)
                {
                    cars[i] = new Car
                    {
                        Cost = random.Next(1000, 100000),
                        Name = Names[random.Next(Names.Length)],
                        Power = random.Next(100, 500)
                    };
                }
                return cars;
            }
        }

        public class Car
        {
            public int Cost { get; set; }
            public int Power { get; set; }
            public string Name { get; set; }

            public string GetInfo()
            {
                return $"{Name} (Cost = {Cost}$, Power = {Power}HP)";
            }

        }

        public class ShopEventsArgs
        {
            public string Message { get; }
            public Car soldCar { get; }

            public ShopEventsArgs(Car car, string message)
            {
                soldCar = car;
                Message = message;
            }
        }
        public class Shop
        {
            public List<Car> Cars { get; private set; }

            public int TotalCarAmount { get; private set; }

            public delegate void SellHandler(object sender, ShopEventsArgs e);

            private event SellHandler _SellNotify;

            public event SellHandler SellNotify 
            {
                add
                {
                    _SellNotify += value;
                    Console.WriteLine($"{value.Method.Name} added!");
                }
                remove
                {
                    _SellNotify -= value;
                    Console.WriteLine($"{value.Method.Name} removed! Now messages will not shown!");
                }
            }

            public Shop(Car [] cars)
            {
                Cars = new List<Car>();
                AddCarRange(cars);
            }
            public void AddCar<T>(T car) where T : Car
            {
                Cars.Add(car);
                TotalCarAmount += 1;
            }

            public void AddCarRange<T>(T[] cars) where T : Car
            {
                Cars.AddRange(cars);
                TotalCarAmount += cars.Length;
            }

            public void SellCar()
            {
                Random random = new Random();
                int sellIndex = random.Next(Cars.Count);
                Car sellCar = Cars[sellIndex];
                _SellNotify?.Invoke(this, new ShopEventsArgs(sellCar, $"Cars {sellCar.GetInfo()} was sold")); // Вызов события
                Cars.RemoveAt(sellIndex);
            }
        }
        public static class EventMain
        {
            public static void MainEventExample()
            {
                Shop carShop = new Shop(Builder.GetCars(10));
                carShop.SellNotify += ShowEventInfo;
                carShop.SellCar();
                carShop.SellCar();
                carShop.SellCar();
                carShop.SellNotify -= ShowEventInfo;
                carShop.SellCar(); // Делегат откреплён, сообщение больше не будет показанно
            }

            private static void ShowEventInfo(object sender, ShopEventsArgs e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.soldCar);
            }
        }
    }
}
