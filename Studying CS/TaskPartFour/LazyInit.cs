using Studying_CS.IOservices;
using System;


namespace TaskPartFour.LazyStudy
{
    public static class LazyInit
    {
        public static void StartExample()
        {
            Lazy<School> school = new Lazy<School>();
            IOService.ShowUserStringWithLineBreak("Input 1 to init lazy class and show data:");
            if (IOService.GetUserString() == "1")
            {
                school.Value.Show_People();
            }
            else
            {
                IOService.ShowUserStringWithLineBreak("Init skipped!");
            }
        }
    }
    public class School
    {
        private Person[] _people = new Person[100];
        public void Show_People()
        {
            foreach (var person in _people)
            {
                IOService.ShowUserStringWithLineBreak(person);
            }
        }
        public School()
        {
            for (int i = 0; i < _people.Length; i++)
            {
                _people[i] = new Person();
            }
        }
    }
    public class Person
    {
        private static int _person_count = 0;
        public int Age { get; set; } = _person_count;
        public string Name { get; set; } = $"Name{_person_count}";

        public override string ToString()
        {
            return $"Name = {Name}, Age = {Age}";
        }

        public Person()
        {
            _person_count++;
        }
    }

}
