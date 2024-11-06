
using System;

namespace Shapes3D
{
    public class Cylinder : Shape3D
    {
        public double Radius { get; }
        public double Height { get; }

        private readonly double _surfaceArea;
        private readonly double _volume;

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
            _surfaceArea = 2 * Math.PI * Radius * (Radius + Height);
            _volume = Math.PI * Radius * Radius * Height;
        }

        public override double GetSurfaceArea() => _surfaceArea;
        public override double GetVolume() => _volume;
    }
}
