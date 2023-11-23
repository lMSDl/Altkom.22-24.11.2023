using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-32) };

            /*var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                PreserveReferencesHandling  = PreserveReferencesHandling.Objects,
                DateFormatString = "yy MM d"
            };*/


            //var json = JsonConvert.SerializeObject(person, settings);

            var json = SerializeFacade.Serialize(person);


            Console.WriteLine(  json);
        }
    }
}
