using Factory;

var shapeFactory = new ShapeFactory();

var shapes = new List<Shape>();

shapes.Add(shapeFactory.CreateShape(ShapeType.Circle));
shapes.Add(shapeFactory.CreateShape(ShapeType.Rectangle));
shapes.Add(shapeFactory.CreateShape(ShapeType.Triangle));

foreach (var shape in shapes)
{
    shape.Render();
}

