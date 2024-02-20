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

    public class Line
    {
        public Point P1 { get; }
        public Point P2 { get; }

        public Line(Point p1, Point p2)
        {
            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);

            P1 = points.OrderBy(p => p.GetDistanceToZero()).ToList().First();
            P2 = points.OrderBy(p => p.GetDistanceToZero()).ToList().Last();
        }

        public double GetLineLength() => Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));

        public override string ToString()
        {
            return P1.ToString() + P2.ToString();
        }
    }
    static void Main()
    {
        List<Line> lines = new List<Line>();
        for (int i = 0; i < 2; i++)
        {
            Point P1 = new Point(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine())
            );
            Point P2 = new Point(
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine())
            );
            lines.Add(new Line(P1, P2));
        }

        Line longerLine = lines.OrderBy(l => l.GetLineLength()).Last();
        Console.WriteLine(longerLine.ToString());
    }
}
