namespace Birthday_Celebrations.Classes
{
    public class Robot : Control
    {
        public Robot(string model, string id)
            : base(id)
        {
            Model = model;
        }

        public string Model { get; private set; }
    }
}
