using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {

        //private readonly int _intValue;
        //private string StringValue { get; }

        private PrivateClassData _data;

        public ClassData(int intValue, string stringValue)
        {
            //_intValue = intValue;
            //StringValue = stringValue;

            _data = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {
            //_intValue = 0;
            //_stringValue = "";
            
            _data.GetIntValue();
            _data.GetStringValue();
        }
    }
}
