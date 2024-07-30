namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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
