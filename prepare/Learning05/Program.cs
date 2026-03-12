Square square = new Square("orange", 12.5);
Circle circle = new Circle("blue", 5);
Rectangle rectangle = new Rectangle("green", 50.67, 25.54);

List<Shape> shapes = new List<Shape>();

shapes.Add(circle);
shapes.Add(square);
shapes.Add(rectangle);

foreach (Shape shape in shapes)
{
    Console.WriteLine($"{shape} | {shape.GetArea()} m² | Color: {shape.GetColor()}");
}

