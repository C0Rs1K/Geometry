namespace Geometry.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Constructor_ValidSides_NoExceptionThrown()
        {
            // Arrange
            double sideOne = 3;
            double sideTwo = 4;
            double sideThree = 5;

            // Act
            try
            {
                Triangle triangle = new(sideOne, sideTwo, sideThree);

                // Assert
                Assert.IsNotNull(triangle);
                Assert.AreEqual(sideOne, triangle.SideOne);
                Assert.AreEqual(sideTwo, triangle.SideTwo);
                Assert.AreEqual(sideThree, triangle.SideThree);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Exception should not be thrown.");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side length cannot be zero or less")]
        public void Triangle_Constructor_InvalidSideOne_ThrowsArgumentException()
        {
            // Arrange
            double sideOne = 0;
            double sideTwo = 4;
            double sideThree = 5;

            // Act
            Triangle triangle = new(sideOne, sideTwo, sideThree);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There is no triangle with such sides")]
        public void Triangle_Constructor_InvalidTriangle_ThrowsArgumentException()
        {
            // Arrange
            double sideOne = 2;
            double sideTwo = 4;
            double sideThree = 10;

            // Act
            Triangle triangle = new(sideOne, sideTwo, sideThree);
        }

        [TestMethod]
        public void Triangle_CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double sideOne = 3;
            double sideTwo = 4;
            double sideThree = 5;
            Triangle triangle = new(sideOne, sideTwo, sideThree);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            double sideOne = 3;
            double sideTwo = 4;
            double sideThree = 5;
            Triangle triangle = new(sideOne, sideTwo, sideThree);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange
            double sideOne = 2;
            double sideTwo = 4;
            double sideThree = 5;
            Triangle triangle = new(sideOne, sideTwo, sideThree);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}