using System.Numerics;

namespace Shapes_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            int randomNumber = Random.Shared.Next(6);
            if (randomNumber == 0)
            {
                return new Circle(new Vector2(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10)), Random.Shared.Next(5));

            }
            else if (randomNumber == 1)
            {
                return new Rectangle(new Vector2(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10)), new Vector2(Random.Shared.Next(10), Random.Shared.Next(10)));

            }
            else if (randomNumber == 2)
            {
                return new Rectangle(new Vector2(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10)), Random.Shared.Next(10));

            }
            else if (randomNumber == 3)
            {
                return new Cuboid(new Vector3(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10), (Random.Shared.Next(-10, 10))), new Vector3(Random.Shared.Next(10), Random.Shared.Next(10), (Random.Shared.Next(10))));
            }
            else if (randomNumber == 4)
            {
                return new Cuboid(new Vector3(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10)), Random.Shared.Next(10));
            }
            else if (randomNumber == 5)
            {
                return new Sphere(new Vector3(Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10), Random.Shared.Next(-10, 10)), Random.Shared.Next(5));

            }
            else throw new Exception("Shape not supported");
           
        }
    }
}