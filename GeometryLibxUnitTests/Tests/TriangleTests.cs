using GeometryLib.Shapes;

namespace GeometryLibxUnitTests.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_ThreeFourFiveTriangle_ReturnsSix()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void IsRight_ThreeFourFiveTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void Constructor_InvalidTriangle_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 100));
        }
    }
}
