namespace Garage
{
    public class Zero : Vehicle, IElectric
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
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeeeooooowwwwwww!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero turns with a wild spin!");
        }
    }
}
