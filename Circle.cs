namespace CalculationLibrary
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        protected override double CalculateArea() => Math.PI * Radius * Radius;
        protected override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}