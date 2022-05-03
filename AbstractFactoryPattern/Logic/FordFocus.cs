using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Logic
{
    internal class FordFocus : IFamillyCar
    {
        public string DriveSafe()
        {
            return "Ford Focus Drive SAFE";
        }
    }
}
