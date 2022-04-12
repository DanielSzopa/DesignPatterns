using Prototype;
using Prototype.Shapes;


#region ShallowClone

Console.WriteLine("ShallowClone => \n\n");

Circle c1 = new Circle()
{
    Radius = 5,
    X = 1,
    Y = 2,
    Border = new Border()
    { Color = "Red", Size = "2px" }
};

Circle c2 = (Circle)c1.ShallowClone();


bool result = ReferenceEquals(c1, c2);
Console.WriteLine($"RefrencesEquals {result}");

bool resultBorder = ReferenceEquals(c1.Border, c2.Border);
Console.WriteLine($"RefrencesEquals Border {resultBorder}");

#endregion


#region DeepClone

Console.WriteLine("\n\nDeepClone => \n\n");

Circle c3 = new Circle()
{
    Radius = 5,
    X = 1,
    Y = 2,
    Border = new Border()
    { Color = "Red", Size = "2px" }
};

Circle c4 = (Circle)c1.ShallowClone();


bool result2 = ReferenceEquals(c3, c4);
Console.WriteLine($"RefrencesEquals {result2}");

bool resultBorder2 = ReferenceEquals(c3.Border, c4.Border);
Console.WriteLine($"RefrencesEquals Border {resultBorder2}");

#endregion



