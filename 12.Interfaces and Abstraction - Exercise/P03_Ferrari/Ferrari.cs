namespace Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            DriverName = driverName;
        }

        public string DriverName { get; private set; }

        public string CarModel { get; } = "488-Spider";

        public string PushTheGasPedal()
            => "Zadu6avam sA!";

        public string UseBrakes()
            => "Brakes!";

        public override string ToString()
            => $"{CarModel}/{UseBrakes()}/{PushTheGasPedal()}/{DriverName}";
    }
}
