using Geometry.Interfaces;

namespace Geometry
{
    public class Triangle : ITriangle
    {
        public double SideOne => _sizeOne;
        public double SideTwo => _sizeTwo;
        public double SideThree => _sizeThree;

        private readonly double _sizeOne;
        private readonly double _sizeTwo;
        private readonly double _sizeThree;

        public Triangle(double sideThree, double sideTwo, double sideOne)
        {
            if (sideOne <= 0)
            {
                throw new ArgumentException("Side length cannot be zero or less", nameof(sideOne));
            }

            if (sideTwo <= 0) 
            {
                throw new ArgumentException("Side length cannot be zero or less", nameof(sideTwo));
            }

            if (sideThree <= 0)
            {
                throw new ArgumentException("Side length cannot be zero or less", nameof(sideThree));
            }

            if (!(sideOne + sideTwo > sideThree) || !(sideOne + sideThree > sideTwo) || !(sideTwo + sideThree > sideOne))
            {
                throw new ArgumentException("There is no triangle with such sides");
            }

            _sizeOne = sideThree;
            _sizeTwo = sideTwo;
            _sizeThree = sideOne;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (SideOne + SideTwo + SideThree) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideOne) * (semiPerimeter - SideTwo) * (semiPerimeter - SideThree));
        }

        public bool IsRightTriangle()
        {
            double maxSide = Math.Max(Math.Max(SideOne, SideTwo), SideThree);

            if (maxSide == SideOne)
                return Math.Pow(SideOne, 2) == Math.Pow(SideTwo, 2) + Math.Pow(SideThree, 2);
            else if (maxSide == SideTwo)
                return Math.Pow(SideTwo, 2) == Math.Pow(SideOne, 2) + Math.Pow(SideThree, 2);
            else
                return Math.Pow(SideThree, 2) == Math.Pow(SideOne, 2) + Math.Pow(SideTwo, 2);
        }
    }
}
