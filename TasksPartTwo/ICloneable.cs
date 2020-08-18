using System;
using System.Collections.Generic;
using System.Text;

namespace TasksPartTwo.StudyInterfaces
{

    internal class Good : ICloneable
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Good { Price = this.Price, Name = (string)Name.Clone() };
        }
    }

    internal class Shop : ICloneable
    {
        public string ShopName { get; set; }
        public List<Good> Goods { get; set; } = new List<Good>();

        public Good TestGood { get; set; } = new Good() { Name = "testgood", Price = 1 };

        public object Clone()
        {
            List<Good> newGoods = new List<Good>(); // Глуб. коп.
            foreach (var good in Goods)
            {
                newGoods.Add((Good)good.Clone()); // Глубокое копирование (создаем новые объекты!!!)
            }
            return new Shop
            {
                TestGood = this.TestGood,// Поверхностоное копирование (копируем только ссылку на объект!!!)
                ShopName = this.ShopName, 
                Goods = newGoods 
            };
        }
    }
}
