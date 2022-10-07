using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Sphere : Shape3D
    {
        public Sphere (Vector3 center, float radius)
        {
            _radius = radius;
            Center = center;
        }
        private float _radius;

        public override float Volume => (4 / 3) * MathF.PI * MathF.Pow(_radius, 3);

        public override Vector3 Center { get;}

        public override float Area => 4 * MathF.PI * MathF.Pow(_radius, 2);

        public override string ToString() => $"Sphere @({Center.X}, {Center.Y}, {Center.Z}) R:{_radius}";


    }
}
