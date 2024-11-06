
namespace Shapes3D
{
    public class Cuboid : Shape3D
    {
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }

        private readonly double _surfaceArea;
        private readonly double _volume;

        public Cuboid(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
            _surfaceArea = 2 * (Width * Height + Height * Depth + Depth * Width);
            _volume = Width * Height * Depth;
        }

        public override double GetSurfaceArea() => _surfaceArea;
        public override double GetVolume() => _volume;
    }
}
