namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Flyweight
{
    internal class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Manufacturer
        {
            get => CarFlyweight.Manufacturer;
            set
            {
                SetValue(x => x.Manufacturer = value);
            }
        }
        public string Model
        {
            get => CarFlyweight.Model; set
            {
                SetValue(x => x.Model = value);
            }
        }
        public string Color
        {
            get => CarFlyweight.Color; set
            {
                SetValue(x => x.Color = value);
            }
        }

        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();

        private void SetValue(Action<CarFlyweight> action)
        {
            var clone = (CarFlyweight)CarFlyweight.Clone();
            action(clone);
            CarFlyweight = FlyweightFactory.Instance.GetFlyweight(clone);
        }
    }
}
