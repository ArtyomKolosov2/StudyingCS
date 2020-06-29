using System;

namespace TasksPartOne
{
    namespace indexer
    {
        public sealed class Indexator
        {
            private string[] data = null;
            private int size = 0;
            public Indexator(int size, string def)
            {
                data = new string[size];
                this.size = size;
                for (int i = 0; i < this.size; i++)
                {
                    data[i] = def;
                }
                this[0] = "Index=0";

            }

            public void show_array()
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.Write("\n");
            }
            public string this[int index]
            {
                get {return data[index]; }
                private set {data[index] = value; }
            }

            public string [] Data
            {
                get { return data; }
            }
        }
    }
}
