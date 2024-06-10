public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше нуля.");
        }
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
