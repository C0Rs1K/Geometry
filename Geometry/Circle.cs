using Geometry.Interfaces;

namespace Geometry
{
    public class Circle : ICircle
    {
        public double Radius => _radius;
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be zero or less", nameof(radius));
            }

            _radius = radius;
        }


        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
