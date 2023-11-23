namespace Altkom._22_24._11._2023.DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable
    {
        public string City { get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}