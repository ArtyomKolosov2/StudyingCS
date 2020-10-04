using Studying_CS.IOservices;
using System;
using System.Collections;

namespace TaskPartFour.LinkedListStudyCS
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name = {Name ?? "No Data"}, Age={Age}";
        }
    }

    public class LinkedListEnumerator<T> : IEnumerator
    {
        private LinkedListStudy<T> list;
        private int position = -1;
        public LinkedListEnumerator(LinkedListStudy<T> linkedList)
        {
            list = linkedList;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position > list.Length)
                {
                    throw new InvalidOperationException();
                }
                return list[position];
            }
        }
        public bool MoveNext()
        {
            bool result = false;
            if (position < list.Length - 1)
            {
                result = true;
                position++;
            }
            return result;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    public class LinkedListStudy<T> : IEnumerable
    {
        private Node<T> FirstNode = null;

        public T this[int index]
        {
            get
            {
                int countIndex = 0;
                Node<T> ptr = FirstNode;
                T result = default;
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                while (ptr != null)
                {
                    if (countIndex == index)
                    {
                        result = ptr.Value;
                        break;
                    }
                    ptr = ptr.Next;
                    countIndex++;
                }
                return result;
            }
            set
            {
                int countIndex = 0;
                Node<T> ptr = FirstNode;
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                while (ptr != null)
                {
                    if (countIndex == index)
                    {
                        ptr.Value = value;
                        break;
                    }
                    ptr = ptr.Next;
                    countIndex++;
                }
            }
        }

        public int Length
        {
            get
            {
                int result = 0;
                Node<T> ptr = FirstNode;
                while (ptr != null)
                {
                    ptr = ptr.Next;
                    result++;
                }
                return result;
            }
        }
        public void Print()
        {
            Node<T> ptr = FirstNode;
            int count = 1;
            while (ptr != null)
            {
                ConsoleIOService.ShowUserStringWithLineBreak($"{count.ToString()}: {ptr.Value.ToString()}");
                count++;
                ptr = ptr.Next;
            }
        }

        public void AddAtFront(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = FirstNode;
            FirstNode = node;
        }

        public void AddAtBack(T value)
        {
            if (FirstNode == null)
            {
                FirstNode = new Node<T>(value);
            }
            else
            {
                Node<T> ptr = FirstNode;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = new Node<T>(value);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node(T value)
        {
            Value = value;
        }
    }
}
