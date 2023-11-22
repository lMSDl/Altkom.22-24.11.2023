using Altkom._22_24._11._2023.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Altkom._22_24._11._2023.DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.AbstractFactory
{
    public class HondaFactory : ICarFactory
    {
        ISedan ICarFactory.ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSedan();
                case "full":
                    return new HondaFullSedan();
                default:
                    throw new Exception();
            }
        }

        ISuv ICarFactory.ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSuv();
                case "full":
                    return new HondaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }

    public class ToyotaFactory : ICarFactory
    {
        ISedan ICarFactory.ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSedan();
                case "full":
                    return new ToyotaFullSedan();
                default:
                    throw new Exception();
            }
        }

        ISuv ICarFactory.ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSuv();
                case "full":
                    return new ToyotaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }
}
