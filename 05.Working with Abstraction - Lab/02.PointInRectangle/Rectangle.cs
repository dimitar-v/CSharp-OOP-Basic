namespace PointInRectangle
{
    public class Rectangle
    {
        public Point UpLeftCorner { get; set; }

        public Point DownRightCorner { get; set; }

        public Rectangle(Point upLeftCorner, Point downRightCorner)
        {
            UpLeftCorner = upLeftCorner;
            DownRightCorner = downRightCorner;
        }

        public bool Contains(Point point) =>
            point.X >= UpLeftCorner.X
            && point.X <= DownRightCorner.X
            && point.Y >= UpLeftCorner.Y
            && point.Y <= DownRightCorner.Y;
    }
}
