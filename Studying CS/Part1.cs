using System;
using TasksPartOne.indexer;
using TasksPartOne.Operatorss;
using TasksPartOne.DiffCastings;
using TasksPartOne.OversRiders;
using TasksPartOne.Shadowing;
using TasksPartOne.GenericsCS;

namespace Studying_CS
{
    public static class Part1
    {
        public static void PartOneStart()
        {
            int amount = 50;
            string splitter = "=";

            Program.center(amount, "Start of first Part", "*");
            Program.center(amount, "Индексаторы", splitter);
            Indexator indexator = new Indexator(5, "Default");
            Console.WriteLine(indexator[3]);
            indexator.show_array();

            Program.center(amount, "Перегрузка операторов", splitter);

            OperatorReboot operatorReboot1 = new OperatorReboot(1);
            OperatorReboot operatorReboot2 = new OperatorReboot(1);

            Console.WriteLine(operatorReboot1 + operatorReboot2);
            Console.WriteLine(operatorReboot1 > operatorReboot2);
            if (operatorReboot1)
            {
                Console.WriteLine("if (operatorReboot) {Size != 0}");
            }
            for (int i = 0; i < 10; i++, operatorReboot1++)
            {
                Console.WriteLine(operatorReboot1);
            }

            Program.center(amount, "Приведение типов", splitter);

            Truck truck = new Truck(500, 25000, 1000);
            Bus bus = new Bus(650, 30000, 40);
            object refernce = new Car(100, 10000, "Volvo");
            Car carbus = new Bus(300, 10000, 20);
            Car cartruck = new Truck(330, 1233, 100);
            try
            {
                Car truckcar = truck;
                Bus newbus = cartruck as Bus;
                if (carbus is Bus bus1)
                {
                    Console.WriteLine(bus1.get_info());
                }
                else
                {
                    Console.WriteLine("Not This Type!");
                }
                if (newbus == null)
                {
                    Console.WriteLine("Invalid Operation!");
                }
                //B obj1 = new A(); // Выдаёт ошибку
                //obj1.Foo();

                B obj2 = new B();
                obj2.Foo();

                A obj3 = new B();
                obj3.Foo();

                Car new_car_ref = (Car)refernce;
                Console.WriteLine(new_car_ref.get_info());
                refernce = (Truck)refernce;

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Program.center(amount, "Переопределение, сокрытие", splitter);

            BaseClassOver baseClassOver = new NewClassOver();
            NewClassOver newClassOver = new NewClassOver();

            baseClassOver.Show(); // !!!
            newClassOver.Show(); // !!!

            BaseEx baseEx = new NewEx("ArtyomK", "Kolosov"); // !!!
            baseEx.Show(); // !!!
            NewEx newEx = new NewEx("ArtyomK", "Kolosov");
            newEx.Show();

            Program.center(amount, "Generics", splitter);

            Truck truck1 = new Truck(1000, 25000, 1000);
            Bus bus2 = new Bus(500, 30000, 50);

            Shop<Car> shop = new Shop<Car>();

            shop.add_one_car(truck1);
            shop.add_one_car(bus2);

            shop.sell_one_car();
            shop.sell_one_car();

            shop.show_selled_info();

            Data<int> data1 = new Data<int>() { Id = 50 };

            Data<string> data2 = new Data<string>() { Id = "StringType" };

            data1.show_id_type();
            data2.show_id_type();

            Program.center(amount, "End of first Part", "*");
            Console.Write("Press Any Key to Continue...\n\n");
            Console.ReadKey();
        }
        
    }

}
