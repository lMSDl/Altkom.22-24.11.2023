using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        
        public Person Parent { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Address Address { get; set; }
        
        public IEnumerable<Person> Children { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address?.Clone();
            //clone.Parent = (Person)Parent?.Clone();
            clone.Children = Children?.ToList();

            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
