using System;
using System.Collections;
using System.Collections.Generic;
using TaskPartFour.LinkedListStudyCS;
using System.Text;

namespace TaskPartFour.IEnumerableStudy
{
    public static class IEnumerableStudy
    {
        public static void StartExample()
        {
            SomeNames names = new SomeNames();
            PrintCollection(names);
            Console.WriteLine("Custom enumerator!");
            names.enumerator = new NamesEnumirator(names.Names);
            PrintCollection(names);
            LinkedListStudy<Person> listStudy = new LinkedListStudy<Person>();
            listStudy.AddAtFront(new Person { Name="Artyom", Age=12});
            listStudy.AddAtFront(new Person { Name="Ilya", Age=21});
            listStudy.AddAtFront(new Person { Name="A", Age=1234});
            listStudy.AddAtBack(new Person { Name="Egor", Age=123});
            Console.WriteLine(listStudy[0]);
            listStudy[0] = new Person { Age = 50 };
            Console.WriteLine(listStudy[3]);
            listStudy.Print();
            PrintCollection(listStudy);

            LinkedListStudy<int> linkedList = new LinkedListStudy<int>();
            linkedList.AddAtFront(1);
            linkedList.AddAtFront(2);
            linkedList.AddAtFront(3);
            linkedList.AddAtFront(4);
            PrintCollection(linkedList);
        }

        public static void PrintCollection<T>(T collection) where T: IEnumerable
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
    public class SomeNames : IEnumerable
    {
        public string[] Names = { "Artyom", "Ilya", "Egor", "Ivan" };
        public IEnumerator enumerator;
        public SomeNames() 
        {
            enumerator = Names.GetEnumerator();
        }
        
        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }
    }

    public class NamesEnumirator : IEnumerator<string>
    {
        private string[] names;
        private int currentPosition = -1;
        public NamesEnumirator(string [] names)
        {
            this.names = names;
        }
        object IEnumerator.Current { get { return Current; } }

        public string Current
        {
            get 
            {
                if (currentPosition==-1 || currentPosition > names.Length)
                {
                    throw new InvalidOperationException();
                }
                return names[currentPosition];
            }
        }

        public void Reset()
        {
            currentPosition = -1;
        }

        public bool MoveNext()
        {
            bool result = false;
            if (currentPosition < names.Length - 1)
            {
                currentPosition++;
                result = true;
            }
            return result;
        }
        public void Dispose() { }
    }
}
