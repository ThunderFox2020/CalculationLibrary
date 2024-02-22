namespace CalculationLibrary
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        protected override double CalculateArea() => Side * Side;
        protected override double CalculatePerimeter() => 4 * Side;
    }
}