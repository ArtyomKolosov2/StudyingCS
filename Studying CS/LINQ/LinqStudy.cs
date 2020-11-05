using Studying_CS.IOservices;
using System.Collections.Generic;
using System.Linq;

namespace Studying_CS.LINQ
{
    public class City
    {
        public int Age { get; set; }
        public int Population { get; set; }
        public string Name { get; set; }
    }

    public class Car
    {
        public int Price { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
    }

    public class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTownName { get; set; }

    }
    public static class LinqStudy
    {
        
        public static void StartExample()
        {
            int amount = 50;
            string split = "=";
            string[] strings = new string[] { "Artyom", "Ilya", "Egor", "Ivan", "Vasya", "Petya", "Jhonny", "Anna" };
            var resultStr = from t in strings
                            where t.ToUpper().StartsWith("A")
                            orderby t descending
                            select t;
            foreach (var res in resultStr)
            {
                IOService.ShowUserStringWithLineBreak(res);
            }
            Program.center(amount, "New example", split);
            var selectedItem = (strings.Where(t=> t.Length==4)).OrderByDescending(t=>t);
            foreach (var res in selectedItem)
            {
                IOService.ShowUserStringWithLineBreak(res);
            }
            Program.center(amount, "New example", split);
            int[] myArray = new int[] { 1, 2, 4, -34, 43, 34, 2,-41,-32, 123, 13, 12, 3, 1, 123, 1443, 423, 1, 2 };
            IEnumerable<int> result = (from t in myArray
                                      where t % 2 == 0 && t > 0
                                      orderby t descending
                                      select t).Distinct();
            foreach (var res in result)
            {
                IOService.ShowUserStringWithLineBreak(res);
            }
            Program.center(amount, "New example", split);
            var Cities = new City[]
            {
                new City{ Age=856, Name="Bransk", Population=123453},
                new City{ Age=1001, Name="Minks", Population=2342123},
                new City{ Age=1001, Name="Orsha", Population=120000},
                new City{ Age=1043, Name="Vitebsk", Population=123453},
                new City{ Age=54, Name="Novopolotsk", Population=50000},
                new City{ Age=69, Name="Soligorsk", Population=50405}
            };
            var searchCitiesResultOne = from t in Cities
                                    where t.Age >= 1000 && t.Population > 0 && t.Population < 1000000
                                    orderby t.Population
                                    select t;
            foreach (var res in searchCitiesResultOne)
            {
                IOService.ShowUserStringWithLineBreak
                    (
                    $"Name: {res.Name}, " +
                    $"Population: {res.Population}, " +
                    $"Age = {res.Age}"
                    );
            }
            Program.center(amount, "New example", split);
            var searchCitiesResultTwo = Cities.Where(t => t.Population > 100000 && t.Population < 1000000).OrderByDescending(t => t.Population);
            foreach (var res in searchCitiesResultTwo)
            {
                IOService.ShowUserStringWithLineBreak
                    (
                    $"Name: {res.Name}, " +
                    $"Population: {res.Population}, " +
                    $"Age = {res.Age}"
                    );
            }
            Program.center(amount, "New example", split);
            var searchCitiesResultThree = from t in Cities
                                          select t.Name;
            foreach (var res in searchCitiesResultThree)
            {
                IOService.ShowUserStringWithLineBreak
                    (
                    res
                    );
            }
            Program.center(amount, "New example", split);
            var searchCitiesResultFour = from c in Cities
                                         let newName = $"CityName: {c.Name}"
                                          select new
                                          {
                                              CityName = newName,
                                              c.Population
                                          };
            foreach (var res in searchCitiesResultFour)
            {
                IOService.ShowUserStringWithLineBreak
                    (
                    $"{res.CityName}, " +
                    $"Population: {res.Population}, "
                    );
            }
            Program.center(amount, "Except linq", split);
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };
            var exceptResult = soft.Except(hard);
            IOService.ShowCollectionWithLineBreak(exceptResult);
            Program.center(amount, "Intersect linq", split);
            var intersectResult = soft.Intersect(hard);
            IOService.ShowCollectionWithLineBreak(intersectResult);
            Program.center(amount, "Union linq", split);
            var unionResult = soft.Union(hard);
            IOService.ShowCollectionWithLineBreak(unionResult);
            Program.center(amount, "Concat linq", split);
            var concatResult = soft.Concat(hard);
            IOService.ShowCollectionWithLineBreak(concatResult);
            Program.center(amount, "Aggregate", split);
            int [] intArray = { 1, 2, 3, 4, 5 };
            int aggregateResult = intArray.Aggregate((a, b) => a * b);
            IOService.ShowUserStringWithOutLineBreak("intArray = ");
            IOService.ShowCollectionWithSplitter(intArray);
            IOService.ShowUserStringWithLineBreak($"1*2*3*4*5 = {aggregateResult}");
            Program.center(amount, "Sum, Max, Min, Average", split);
            IOService.ShowUserStringWithLineBreak($"Sum of intArray = {intArray.Sum()}");
            IOService.ShowUserStringWithLineBreak($"Max of intArray = {intArray.Max()}");
            IOService.ShowUserStringWithLineBreak($"Min of intArray = {intArray.Min()}");
            IOService.ShowUserStringWithLineBreak($"Average of intArray = {intArray.Average()}");
            IOService.ShowUserStringWithLineBreak($"Average of cities population = {Cities.Average(x => x.Population)}");
            Program.center(amount, "Skip, Take, TakeWhile, SkipWhile", split);
            var skipRes = intArray.Skip(3);
            IOService.ShowCollectionWithLineBreak(skipRes);
            var takeRes = intArray.Skip(2);
            IOService.ShowCollectionWithLineBreak(takeRes);
            var takeWhileRes = intArray.TakeWhile(x => x % 2 != 0);
            IOService.ShowUserStringWithLineBreak("Take while x % 2 != 0");
            IOService.ShowCollectionWithLineBreak(takeWhileRes);
            var skipWhileRes = intArray.SkipWhile(x => x % 2 == 0);
            IOService.ShowUserStringWithLineBreak("Skip while x % 2 == 0");
            IOService.ShowCollectionWithLineBreak(skipWhileRes);
            Program.center(amount, "Group By", split);
            var groupByResult = from city in Cities
                                orderby city.Age
                                group city by city.Age;
            foreach (var group in groupByResult)
            {
                IOService.ShowUserStringWithLineBreak(group.Key);
                foreach (var t in group)
                {
                    IOService.ShowUserStringWithLineBreak(t.Name);
                }
            }
            var cars = new Car[]
            {
                new Car{Price=10000, Company="Ford", Age=10},
                new Car{Price=10000, Company="Opel", Age=2},
                new Car{Price=10000, Company="Audi", Age=10},
                new Car{Price=1000, Company="Ford", Age=4},
                new Car{Price=23000, Company="Audi", Age=12},
                new Car{Price=145000, Company="Ferrari", Age=10},
                new Car{Price=1030, Company="Ford", Age=9},
                new Car{Price=12100, Company="Opel", Age=24},
                new Car{Price=121020, Company="Ferrari", Age=24}
            };
            var carsOrderByRes = from car in cars
                                 orderby car.Age
                                 group car by car.Company into p
                                 select new { Name = p.Key, Count = p.Count() };
            var carsOrderByResAlternate = cars.GroupBy(p => p.Company)
                        .Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var group in carsOrderByRes)
            {
                IOService.ShowUserStringWithLineBreak($"{group.Name} : {group.Count}");
            }
            foreach (var group in carsOrderByResAlternate)
            {
                IOService.ShowUserStringWithLineBreak($"{group.Name} : {group.Count}");
            }
            Program.center(amount, "Join, GroupJoin, Zip", split);
            var citizens = new Citizen[]
            {
                new Citizen{HomeTownName="Minsk", Name="Vasya"},
                new Citizen{HomeTownName="Orsha", Name="Vanya"},
                new Citizen{HomeTownName="Orsha", Name="Ilya"},
                new Citizen{HomeTownName="Vitebsk", Name="Anna"},
                new Citizen{HomeTownName="Soligorsk", Name="Petya"},
                new Citizen{HomeTownName="Soligorsk", Name="Egor"},
            };
            var joinRes1 = from citizen in citizens
                          join city in Cities on citizen.HomeTownName equals city.Name
                          orderby city.Name
                          select new { CityName = city.Name, CitizenName = citizen.Name };
            var joinRes2 = citizens.Join(Cities,
             p => p.HomeTownName,
             t => t.Name,
             (p, t) => new { CityName = t.Name, CitizenName = p.Name });
            foreach (var res in joinRes1)
            {
                IOService.ShowUserStringWithLineBreak($"{res.CitizenName} lives in {res.CityName}");
            }
            IOService.ShowUserStringWithLineBreak("LIQN extension");
            foreach (var res in joinRes2)
            {
                IOService.ShowUserStringWithLineBreak($"{res.CitizenName} lives in {res.CityName}");
            }
            var joinRes3 = Cities.GroupJoin(citizens,
                t => t.Name,
                c => c.HomeTownName,
                (c, t) => new
                {
                    Name = c.Name,
                    Population = c.Population,
                    Citizens = t.Select(p => p.Name)
                });
            foreach (var res in joinRes3)
            {
                IOService.ShowUserStringWithLineBreak(res.Name);
                foreach (var info in res.Citizens)
                {
                    IOService.ShowUserStringWithLineBreak(info);
                }
                IOService.ShowUserStringWithOutLineBreak("\n\n");
            }
            var zipRes = strings.Zip(
                soft,
                (name, companie) => new
                {
                    Name = name,
                    Companie = companie
                });
            foreach (var worker in zipRes)
            {
                IOService.ShowUserStringWithLineBreak($"{worker.Name} works in {worker.Companie}");
            }
        }
    }
}
