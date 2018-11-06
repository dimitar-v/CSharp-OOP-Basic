namespace Border_Control
{
    public class Control : IIdentifiable
    {
        public Control(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }

        public override string ToString()
            => Id;
    }
}
