using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Circle : Shape2D
    {
        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
        }
        private Vector2 _center;
        private float _radius;
        public override float Circumference => 2 * MathF.PI * _radius;

        public override Vector3 Center => new Vector3 (_center.X, _center.Y,0);
        
        public override float Area => _radius * _radius * MathF.PI;
        public override string ToString() => $"Circle @{_center}: R = {_radius}";

    }
}
