using Shapes_Library;
using System;
using System.Numerics;

//Circle rund = new Circle(new Vector2(1,7), 5);
//Console.WriteLine(rund.Area);


Console.WriteLine("Here are 20 randomly created shapes:\n"); 

List<Shape> listOfShapes = new();
for (int i = 0; i < 20; i++)
{
    Shape randomShape = Shape.GenerateShape();
    Console.WriteLine(randomShape);
    listOfShapes.Add(randomShape);

}

float avarage = listOfShapes.Average(s => s.Area);
Console.WriteLine();
Console.WriteLine($"The avarage area of all shapes is: {avarage}");
