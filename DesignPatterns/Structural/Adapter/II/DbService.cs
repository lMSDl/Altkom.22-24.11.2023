using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Adapter.II
{
    public class DbService
    {
        private IEnumerable<DbPerson> _people = new List<DbPerson>()
        {
            new DbPerson {FirstName = "Adam", LastName = "Adamski", BirthDate = DateTime.Now.AddYears(-24)},
            new DbPerson {FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-25)},
        };

        public IEnumerable<DbPerson> Read()
        {
            return _people.ToList();
        }
    }
}
}
