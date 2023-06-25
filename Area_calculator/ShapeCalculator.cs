namespace Area_calculator
{
    public static class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }

        public static bool IsRightTriangle(Triangle triangle)
        {
            double sideATriangle = Math.Pow(triangle.SideA, 2);
            double sideBTriangle = Math.Pow(triangle.SideB, 2);
            double sideCTriangle = Math.Pow(triangle.SideC, 2);
           
            return 
                sideATriangle + sideBTriangle == sideCTriangle ||
                sideATriangle + sideCTriangle == sideBTriangle ||
                sideBTriangle + sideCTriangle == sideATriangle;
        }
    }
}
