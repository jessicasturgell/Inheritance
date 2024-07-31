public interface IElectric
{
    public double CurrentChargePercentage { get; set; }
    public void ChargeBattery();
    void Drive();
    void Turn();
    void Stop();
}

public interface IGas
{
    public double CurrentTankPercentage { get; set; }
    public void RefuelTank();
    void Drive();
    void Turn();
    void Stop();
}
