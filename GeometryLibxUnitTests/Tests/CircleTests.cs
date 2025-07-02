using GeometryLib.Shapes;

namespace GeometryLibxUnitTests.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_WithRadius5_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.Equal(Math.PI * 25, area, 5); // 5 знаков точности
        }
        [Fact]
        public void Constructor_WithNegativeRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
