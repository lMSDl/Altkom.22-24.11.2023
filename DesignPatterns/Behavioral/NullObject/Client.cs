namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {
        public static void Execute()
        {

            var objects = new AbstractObject[] { new RealObject(), new NullObject() };
            var random = new Random();

            while (true)
            {
                var value = random.Next(0, objects.Length);
                Console.ReadLine(  );

                objects[value].Method1();
                objects[value].Method2();
                objects[value].Method3();

                /*if (objects[value] != null)
                    objects[value].Method1();
             
               objects[value]?.Method2();
                
                if (objects[value] is not null)
                    objects[value].Method3();*/
            }

        }
    }
}
