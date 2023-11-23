using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {
        public static FlyweightFactory Instance { get; } = new FlyweightFactory();


        private Dictionary<string, CarFlyweight> _flyweights;

        static FlyweightFactory() { }
        private FlyweightFactory()
        {
        }

        public void Initialize(params CarFlyweight[] flyweights)
        {
            _flyweights = flyweights.ToDictionary(GetKey);
        }

        private string GetKey(CarFlyweight carFlyweight)
        {
            return string.Join("_",
            typeof(CarFlyweight).GetProperties()
                .Where(x => x.CanWrite && x.CanRead)
                .OrderBy(x => x.Name)
                .Select(x => x.GetValue(carFlyweight)));
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            var key = GetKey(carFlyweight);

            if (_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine($"Pobieramy stan ze słownika {key}");
                return flyweight;
            }

            Console.WriteLine($"Dodajemy stan do słownika: {key}");
            _flyweights[key] = carFlyweight;
            return carFlyweight;
        }


        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Fabryka posiada {_flyweights.Count} stanów:");

            foreach (var item in _flyweights)
            {
                stringBuilder.AppendLine(item.Key);
            }

            return stringBuilder.ToString();
        }
    }
}
