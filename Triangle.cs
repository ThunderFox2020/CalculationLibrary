namespace CalculationLibrary
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool IsRightTriangle
        {
            get
            {
                double[] sides = { SideA, SideB, SideC };
                Array.Sort(sides);

                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }
        }

        protected override double CalculateArea()
        {
            double p = Perimeter / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        protected override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}