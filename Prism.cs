
using Shapes;

namespace Shapes3D
{
    public class Prism : Shape3D
    {
        public double SideLength { get; }
        public int Faces { get; }
        public double Height { get; }

        private readonly double _surfaceArea;
        private readonly double _volume;

        public Prism(double sideLength, int faces, double height)
        {
            SideLength = sideLength;
            Faces = faces;
            Height = height;
            
            Polygon basePolygon = new Polygon(SideLength, Faces);
            double baseArea = basePolygon.Area;
            double perimeter = basePolygon.Perimeter;
            
            _surfaceArea = 2 * baseArea + perimeter * Height;
            _volume = baseArea * Height;
        }

        public override double GetSurfaceArea() => _surfaceArea;
        public override double GetVolume() => _volume;
    }
}
