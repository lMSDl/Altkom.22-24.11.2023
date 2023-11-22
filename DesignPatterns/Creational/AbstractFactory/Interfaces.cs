﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.AbstractFactory
{
    internal class Interfaces
    {
        public interface ICar
        {
            string Name();
        }

        public interface ISedan : ICar
        {

        }

        public interface ISuv : ICar
        {

        }


        public interface ICarFactory
        {
            ISedan ManufactureSedan(string segment);
            ISuv ManufactureSuv(string segment);
        }
    }
}
