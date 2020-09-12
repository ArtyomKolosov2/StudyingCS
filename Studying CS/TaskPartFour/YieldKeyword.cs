using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TaskPartFour.YieldStudy
{
    public static class YieldKeyword
    {
        public static void StartExample()
        {
            Library library = new Library();
            foreach (Book book in library)
            {
                Console.WriteLine($"Take Time = {book.TakeDate.ToString("HH:mm:ss")} Name = {book.Name}");
            }
            foreach (Person person in library.GetPerson())
            {
                Console.WriteLine($"Name = {person.Name}, Age = {person.Age.ToString()}");
            }
        }
    }
    public class Library : IEnumerable
    {
        private Book[] _books = 
        { 
            new Book {Name="Ak1" }, 
            new Book {Name="Ak2" }, 
            new Book {Name="Ak3" }, 
        };
        private Person[] _persons =
        {
            new Person{Name="Egor", Age=18},
            new Person{Name="Ilya", Age=28},
            new Person{Name="Petya", Age=38}
        };
        public IEnumerable GetPerson()
        {
            for (int i = 0; i < _persons.Length; i++)
            {
                yield return _persons[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _books.Length; i++)
            {
                yield return _books[i];
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Book
    {
        public string Name { get; set; }
        public DateTime TakeDate { get; set; } = DateTime.Now;
    }
}
