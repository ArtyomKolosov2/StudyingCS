using Studying_CS.IOservices;
using System;
using System.Collections.Generic;

namespace TasksPartTwo
{
    namespace StudyInterfaces
    {
        public static class Interfaces
        {
            public static void StartExample()
            {
                Car car = new Car();
                Person person = new Person();
                Example example = new Example();
                ShowPoly(car);
                ShowPoly(person);
                ((ISchool)example).Study();
                ((IUniversity)example).Study();
                IComparableStudy study = new IComparableStudy();
                study.ShowArray(study.HumansOne);
                Array.Sort(study.HumansOne);
                study.ShowArray(study.HumansOne);
                study.ShowArray(study.HumansTwo);
                Array.Sort(study.HumansTwo, new HumanAgeCompare());
                study.ShowArray(study.HumansTwo);
                Array.Sort(study.HumansTwo, new HumanNameCompare());
                study.ShowArray(study.HumansTwo);
                Truck truck = new Truck();
                truck.Move();
                ((IMoveAction)truck).Move();
                Test<int> test1 = new Test<int> { Data = 555 };
                Test<string> test2 = new Test<string> { Data = "TestTwoStr" };
                ConsoleIOService.ShowUserStringWithLineBreak($"{test1.Data} = {test1.Data.GetType()}");
                ConsoleIOService.ShowUserStringWithLineBreak($"{test2.Data} = {test2.Data.GetType()}");
                Shop shop = new Shop()
                {
                    ShopName = "StartShopName",
                    Goods = new List<Good>()
                    {
                        new Good(){Price=100,Name="Test1"},
                        new Good(){Price=200,Name="Test2"},
                        new Good(){Price=300,Name="Test3"}
                    }
                };
                Shop copiedShop = (Shop)shop.Clone();
                ConsoleIOService.ShowUserStringWithLineBreak("Original shop name - " + shop.TestGood.Name);
                ConsoleIOService.ShowUserStringWithLineBreak("Copied shop name - " + copiedShop.TestGood.Name);
                shop.TestGood.Name = "!newShopName!";
                ConsoleIOService.ShowUserStringWithLineBreak("Original name changed - " + shop.TestGood.Name);
                ConsoleIOService.ShowUserStringWithLineBreak("Copied shop name- " + copiedShop.TestGood.Name);

            }

            private static void ShowPoly(IMovable movable)
            {
                movable.Move();
                ConsoleIOService.ShowUserStringWithLineBreak(movable.IsMoved());
            }
        }

        interface ISchool
        {
            void Study();
        }

        interface IUniversity
        {
            void Study();
        }

        interface IMoveAction
        {
            void Move();
            int Speed { get; set; }
        }

        public class CarTest // : IMoveAction
        {
            public void Move()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Car is moving");
            }
            //public void virtual Move(){...}; or abstract virtual Move(){...};
        }

        public class Truck : CarTest, IMoveAction // IMoveAction уже реализован в класса CarTest (класс CarTest должен быть указан первым)
        {
            public int Speed { get; set; } // для реализации в новом класса можно использовать сокрытие и\или переопределение 
            //абстрактных и виртуальных методов
            //public override void Move(){...};
            //public new void Move(){...};
            //Также можно использовать явную реализацию
            void IMoveAction.Move()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("ActionMove");
            }
        }

        public class Example : ISchool, IUniversity
        {
            void ISchool.Study()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("School");
            }

            void IUniversity.Study()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Univerity");
            }
        }
        public interface IMovable
        {
            void Move();
            bool IsMoved();
        }

        public interface ITest<T>
        {
            T Data { get; set; }
        }

        public class Test<T> : ITest<T>
        {
            T _data;
            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }
        }


        public class Car : IMovable
        {
            public bool Moved { get; set; } = false;
            public void Move()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Car Moving!");
                Moved = true;
            }

            public bool IsMoved()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("IsMoved CarClass");
                return Moved;
            }
        }

        public class Person : IMovable
        {
            public bool Moved { get; set; } = false;
            public void Move()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Person Moving!");
                Moved = true;
            }

            public bool IsMoved()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("IsMoved PersonClass");
                return Moved;
            }
        }
    }
}
