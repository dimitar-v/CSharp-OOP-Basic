namespace Ferrari
{
    public interface ICar
    {
        string DriverName { get; }

        string CarModel { get; }

        string UseBrakes();

        string PushTheGasPedal();
    }
}
