namespace Area_calculator.Tests
{
    public class ShapeCalculatorTests
    {
        [Fact]
        public void CalculateArea_Circle_ReturnsCorrectArea()
        {
            //Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);

            //Act
            var actualArea = ShapeCalculator.CalculateArea(circle);

            //Assert
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            //Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            //Act
            double actualArea = ShapeCalculator.CalculateArea(triangle);

            //Assert
            double expectedArea = 6.0;
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightTriangle_ReturnsTrue()
        {
            //Arrange

            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            //Act
            bool isRightTriangle = ShapeCalculator.IsRightTriangle(triangle);

            //Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangle_NonRightTriangle_ReturnsFalse()
        {
            //Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 6.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            //Act
            bool isRightTriangle = ShapeCalculator.IsRightTriangle(triangle);

            //Assert
            Assert.False(isRightTriangle);
        }
    }
}
