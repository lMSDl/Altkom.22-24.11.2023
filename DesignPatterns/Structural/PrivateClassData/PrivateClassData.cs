﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.PrivateClassData
{
    internal class PrivateClassData
    {
        private int _intValue;
        private string _stringValue;

        public PrivateClassData(int intValue, string stringValue)
        {
            _intValue = intValue;
            _stringValue = stringValue;
        }

        public int GetIntValue()
        {
            return _intValue;
        }

        public string GetStringValue() { return _stringValue; }
    }
}
