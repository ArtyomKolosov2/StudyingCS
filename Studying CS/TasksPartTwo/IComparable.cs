using System;
using System.Collections.Generic;

namespace TasksPartTwo.StudyInterfaces
{
    public class IComparableStudy
    {
        public Human[] HumansOne = new Human[]
        {
            new Human{Age=15,Name="Vasya"},
            new Human{Age=29,Name="Petya"},
            new Human{Age=19,Name="Misha"}
        };

        public Human[] HumansTwo = new Human[]
        {
            new Human{Age=28,Name="Artyom"},
            new Human{Age=54,Name="Ilya"},
            new Human{Age=23,Name="Egor"}
        };

        public void ShowArray(Human[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
        }

    }

    public class Human : IComparable<Human>
    {
        public int Age { get; set; }
        public string Name { get; set; } = null;

        public override string ToString()
        {
            return $"(Name = {Name ?? "NoData"}, Age = {Age})";
        }
        public int CompareTo(Human o1)
        {
            int result = 0;
            result = this.Age.CompareTo(o1.Age);
            return result;
        }
    }

    public class HumanAgeCompare : IComparer<Human>
    {
        public int Compare(Human o1, Human o2)
        {
            int result;
            if (o1.Age > o2.Age)
            {
                result = 1;
            }
            else if (o1.Age == o2.Age)
            {
                result = 0;
            }
            else
            {
                result = -1;
            }
            return result;
        }
    }

    public class HumanNameCompare : IComparer<Human>
    {
        public int Compare(Human o1, Human o2)
        {
            int result;
            if (o1.Name.Length > o2.Name.Length)
            {
                result = 1;
            }
            else if (o1.Name.Length < o2.Name.Length)
            {
                result = -1;
            }
            else
            {
                result = 0;
                for (int i = 0; i < o1.Name.Length; i++)
                {
                    if (o1.Name[i] > o2.Name[i])
                    {
                        result = 1;
                        break;
                    }
                    else if (o1.Name[i] < o2.Name[i])
                    {
                        result = -1;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
