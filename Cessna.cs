namespace Garage
{
    public class Cessna : Vehicle, IGas
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
            Console.WriteLine(
                $"The {MainColor} Cessna flashes by you like a hurricane! Zzzzooooooooom!"
            );
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna slows to a stop with quiet precision.");
        }
    }
}
