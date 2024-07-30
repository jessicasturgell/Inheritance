namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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
