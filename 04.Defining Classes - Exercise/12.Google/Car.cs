namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car()
        {
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Modle
        {
            get { return model; }
            set { model = value; }
        }
    }
}
