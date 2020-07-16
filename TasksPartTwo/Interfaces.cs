using System;
using System.Collections.Generic;
using System.Text;

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
                ShowPoly(car);
                ShowPoly(person);
            }

            private static void ShowPoly(IMovable movable)
            {
                movable.Move();
                Console.WriteLine(movable.IsMoved());
            }
        }
        public interface IMovable
        {
            void Move();
            bool IsMoved();
        }

        public class Car : IMovable
        {
            public bool Moved { get; set; } = false;
            public void Move()
            {
                Console.WriteLine("Car Moving!");
                Moved = true;
            }

            public bool IsMoved()
            {
                Console.WriteLine("IsMoved CarClass");
                return Moved;
            }
        }

        public class Person : IMovable
        {
            public bool Moved { get; set; } = false;
            public void Move()
            {
                Console.WriteLine("Person Moving!");
                Moved = true;
            }

            public bool IsMoved()
            {
                Console.WriteLine("IsMoved PersonClass");
                return Moved;
            }
        } 
    }
}
