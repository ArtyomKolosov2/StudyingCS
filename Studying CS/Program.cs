using System;
using Tasks.indexer;
using Tasks.Operatorss;
using Tasks.DiffCastings;
namespace Studying_CS
{
    class Program
    {
        static void Main()
        {
            int amount = 50;
            string splitter = "=";


            center(amount, "Индексаторы", splitter);
            Indexator indexator = new Indexator(5, "Default");
            Console.WriteLine(indexator[3]);
            indexator.show_array();

            center(amount, "Перегрузка операторов", splitter);

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

            center(amount, "Приведение типов", splitter);

            Truck truck = new Truck(500, 25000, 1000);
            Bus bus = new Bus(650, 30000, 40);
            object refernce = new Car(100, 10000, "Volvo");
            Car carbus = new Bus(300, 10000, 20);
            Car cartruck = new Truck(330, 1233, 100);
            try
            {
                Car truckcar = truck;
                Bus newbus =  cartruck as Bus;
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

            center(amount, "Переопределение, сокрытие", splitter);


            Console.ReadKey();
        }

        static void center(int amount, string msg, string symbol)
        {
            int divided_amount = amount / 2;
            for (int i = 0; i < amount; i++)
            {
                
                if (i == divided_amount)
                {
                    Console.Write(msg);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.Write("\n");
        }
        static void print_splitter(int amount, string splitter)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(splitter);
            }
            Console.Write("\n");
        }
    }
}
