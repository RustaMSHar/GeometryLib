using System;
using Xunit;

namespace GeometryLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_Area_Calculation_Is_Correct()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expectedArea, circle.GetArea(), precision: 5);
        }

        [Fact]
        public void Triangle_Area_Calculation_Is_Correct()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6;
            Assert.Equal(expectedArea, triangle.GetArea(), precision: 5);
        }

        [Fact]
        public void Triangle_Is_RightAngled()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void ShapeAreaCalculator_Works_With_Circle()
        {
            Shape shape = new Circle(5);
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();
            double expectedArea = Math.PI * Math.Pow(5, 2);
            Assert.Equal(expectedArea, calculator.CalculateArea(shape), precision: 5);
        }

        [Fact]
        public void ShapeAreaCalculator_Works_With_Triangle()
        {
            Shape shape = new Triangle(3, 4, 5);
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();
            double expectedArea = 6;
            Assert.Equal(expectedArea, calculator.CalculateArea(shape), precision: 5);
        }
    }
}
