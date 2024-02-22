namespace CalculationLibrary
{
    public abstract class Shape
    {
        public double Area => CalculateArea();
        public double Perimeter => CalculatePerimeter();

        protected abstract double CalculateArea();
        protected abstract double CalculatePerimeter();
    }
}