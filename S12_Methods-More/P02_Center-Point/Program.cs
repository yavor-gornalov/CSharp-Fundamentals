internal class Program
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetDistanceToZero() => Math.Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X}, {Y})";
    }

    static void Main()
    {
        List<Point> points = new List<Point>();
        for (int i = 0; i < 2; i++)
        {
            points.Add(new Point(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()))
            );
        }

        Point bestPoint = points.OrderBy(p => p.GetDistanceToZero()).First();
        Console.WriteLine(bestPoint.ToString());
    }
}
