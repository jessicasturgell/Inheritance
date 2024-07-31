namespace Garage
{
    public class Ram : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        private double _currentTankPercentage;
        public double CurrentTankPercentage
        {
            get { return _currentTankPercentage; }
            set { _currentTankPercentage = value; }
        }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine("Fueled up!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you! Rrrrrumbbbble!");
        }
    }
}
