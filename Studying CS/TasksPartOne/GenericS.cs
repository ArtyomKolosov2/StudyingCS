using Studying_CS.IOservices;
using System;
using System.Collections.Generic;

namespace TasksPartOne
{
    namespace GenericsCS
    {
        public class Shop<T> where T : DiffCastings.Car
        {

            public int Income { get; private set; } = 0;
            private List<T> Cars { get; set; }
            private List<string> info { get; set; }

            public Shop()
            {
                Cars = new List<T>();
                info = new List<string>();
            }

            public void sell_one_car()
            {
                Random random = new Random();
                int delete_index = random.Next(Cars.Count);
                T sell_car = Cars[delete_index];
                Cars.RemoveAt(delete_index);
                info.Add(sell_car.get_info());
                Income += sell_car.Cost;
            }


            public void show_selled_info()
            {
                ConsoleIOService.ShowUserStringWithLineBreak("Selled cars: ");
                foreach (string str in info)
                {
                    ConsoleIOService.ShowUserStringWithLineBreak(str);
                }
                Console.Write("\n");
            }
            public void add_one_car(T car)
            {
                Cars.Add(car);
            }
        }

        public class Data<T>
        {
            public T Id { get; set; } = default;

            public void show_id_type()
            {
                ConsoleIOService.ShowUserStringWithLineBreak(string.Format("Тип переменной Id = {0}", Id.GetType()));
            }
        }
    }
}
