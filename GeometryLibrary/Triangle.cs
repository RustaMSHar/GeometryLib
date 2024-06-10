public class Triangle : Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Все стороны должны быть больше нуля.");
        }
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("Сумма двух любых сторон должна быть больше оставшейся стороны.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
}
