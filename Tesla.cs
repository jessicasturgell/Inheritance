namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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
