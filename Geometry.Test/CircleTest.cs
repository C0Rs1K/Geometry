namespace Geometry.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle_Constructor_ValidRadius_NoExceptionThrown()
        {
            // Arrange
            double radius = 5;

            // Act
            try
            {
                Circle circle = new(radius);

                // Assert
                Assert.IsNotNull(circle);
                Assert.AreEqual(radius, circle.Radius);
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not be thrown.");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Radius cannot be zero or less")]
        public void Circle_Constructor_InvalidRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = 0;

            // Act
            Circle circle = new(radius);
        }

        [TestMethod]
        public void Circle_CalculateArea_ValidCircle_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}