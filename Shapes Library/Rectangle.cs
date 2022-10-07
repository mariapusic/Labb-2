using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Rectangle : Shape2D
    {
        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _size = size;
        }
        public Rectangle(Vector2 center, float width)
        {
            _center = center;
            _size = new Vector2(width);
        }
        private Vector2 _center;
        private Vector2 _size;
        private float _width;


        public override float Circumference => _size.X * 2 + _size.Y * 2;

        public override Vector3 Center => new Vector3 (_center.X, _center.Y, 0);

        public override float Area => _size.X * _size.Y;

        public bool IsSquare => _size.X == _size.Y;
        public override string ToString()
        {
            if (IsSquare)
            {
                return ($"Square @({_center.X}, {_center.Y}) W:{_size.X} H:{_size.Y}");
    
            }
            else
            {
                return ($"Rectangle @({_center.X},{_center.Y}) W:{_size.X} H:{_size.Y}");
            }
        }



    }
}
