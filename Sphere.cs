
using System;

namespace Shapes3D
{
    public class Sphere : Shape3D
    {
        public double Radius { get; }

        private readonly double _surfaceArea;
        private readonly double _volume;

        public Sphere(double radius)
        {
            Radius = radius;
            _surfaceArea = 4 * Math.PI * Radius * Radius;
            _volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
        }

        public override double GetSurfaceArea() => _surfaceArea;
        public override double GetVolume() => _volume;
    }
}
