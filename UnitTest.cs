using CalculationLibrary;

namespace CalculationLibraryTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(314, Math.Round(circle.Area));
        }

        [TestMethod]
        public void CirclePerimeterCalculation()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(63, Math.Round(circle.Perimeter));
        }

        [TestMethod]
        public void SquareAreaCalculation()
        {
            Square square = new Square(10);
            Assert.AreEqual(100, square.Area);
        }

        [TestMethod]
        public void SquarePerimeterCalculation()
        {
            Square square = new Square(10);
            Assert.AreEqual(40, square.Perimeter);
        }

        [TestMethod]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
        }

        [TestMethod]
        public void TrianglePerimeterCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(12, triangle.Perimeter);
        }

        [TestMethod]
        public void IsRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.IsRightTriangle);
        }

        [TestMethod]
        public void AreaCalculatorTesting()
        {
            Shape unknownShape = new Triangle(10, 15, 20);
            Assert.AreEqual(73, Math.Round(Calculator.CalculateArea(unknownShape)));
        }

        [TestMethod]
        public void PerimeterCalculatorTesting()
        {
            Shape unknownShape = new Triangle(10, 15, 20);
            Assert.AreEqual(45, Math.Round(Calculator.CalculatePerimeter(unknownShape)));
        }
    }
}