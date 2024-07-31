namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }
        private double _currentChargePercentage;
        public double CurrentChargePercentage
        {
            get { return _currentChargePercentage; }
            set { _currentChargePercentage = value; }
        }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine("Fully charged!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes past you! Mmmmmmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla whizzes around the turn!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla slams to a sudden stop!");
        }
    }
}
