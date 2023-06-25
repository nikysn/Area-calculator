
namespace Area_calculator
{
    public class Triangle : IShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC) 
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            return area;
        }
    }
}
