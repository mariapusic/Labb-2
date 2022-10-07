using System.Numerics;

namespace Shapes_Library
{
    public class Cuboid : Shape3D
    {
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }
        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3 (width);
        }
        private Vector3 _center;
        private Vector3 _size;
        private float _width;
        public override float Volume => _size.X * _size.Y * _size.Z;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public override float Area => 2 * ((_size.X * _size.Z) + (_size.Z * _size.Y) + (_size.X * _size.Y));

        public bool IsCube => _size.X == _size.Y && _size.X == _size.Z;
        public override string ToString()
        {
            if (IsCube)
            { 
               return $"Cube @{_center.X}, {_center.Y}, {_center.Z} W:{_size.X} H:{_size.Y} L:{_size.Z}";
            }
            else
            {
                return $"Cuboid @{_center.X}, {_center.Y}, {_center.Z} W:{_size.X} H:{_size.Y} L:{_size.Z}";
            }

        }
    }
}
