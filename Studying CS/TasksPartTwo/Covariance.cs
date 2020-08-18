using System;

namespace TasksPartTwo.StudyDelegates
{
    namespace StudyCovariance
    {
        public class StudyCovariance
        {
            public delegate CargoPlane CreatePlane(); // Ковариативный делегат
            public delegate void ShowPlaneInfo(Plane plane); // Контрвариативный делегат

            public CreatePlane createPlane;
            public ShowPlaneInfo info;

            public delegate T Builder<out T>(string Name);

            public delegate void GetInfo<in T>(T obj);

            public void StartExample()
            {
                createPlane = GetPlane;
                CargoPlane plane = createPlane(); // Ковариативность
                info = ShowInfo;
                info(plane); // Ковариативность

                Builder<Client> clientBuilder = GetClient;
                Builder<Person> personBuilder1 = clientBuilder;     // ковариантность
                Builder<Person> personBuilder2 = GetClient;         // ковариантность

                Person p = personBuilder1("Tomson"); // вызов делегата
                p.Display();

                GetInfo<Person> personInfo = PersonInfo;
                GetInfo<Client> clientInfo = personInfo;      // контравариантность

                Client client = new Client { Name = "Tomson" };
                clientInfo(client); // Client: Tomson

            }

            private static void PersonInfo(Person p) => p.Display();
            private static void ClientInfo(Client cl) => cl.Display();
            private CargoPlane GetPlane()
            {
                CargoPlane newPlane = new CargoPlane { Model = "AirBus" };
                return newPlane;
            }

            private void ShowInfo(Plane plane)
            {
                Console.WriteLine($"Model {plane.Model}");
            }

            private Person GetPerson(string name)
            {
                return new Person { Name = name };
            }
            private Client GetClient(string name)
            {
                return new Client { Name = name };
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public virtual void Display() => Console.WriteLine($"Person {Name}");
        }
        public class Client : Person
        {
            public override void Display() => Console.WriteLine($"Client {Name}");
        }

        public class Plane
        {
            public string Model { get; set; }
        }

        public class CargoPlane : Plane
        {
        } 
    }
    namespace MainCSDelegates
    {
        public static class ActionDel
        {

            public static void StartExample()
            {
                Action<int, int> action = Add;
                DoTheThing(6, 5, action);
                action = Multi;
                DoTheThing(6, 4, action);
            }
            private static void Add(int x, int y)
            {
                Console.WriteLine(x + y);
            }

            private static void Multi(int x, int y)
            {
                Console.WriteLine(x * y);
            }

            private static void DoTheThing(int x, int y, Action<int, int> operation)
            {
                if (x > y)
                {
                    operation(x, y);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
