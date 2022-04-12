namespace Prototype.Shapes
{
    public class Rectangle : Shape
    {
        public override Shape ShallowClone()
        {
           return (Rectangle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render Rectangle");
        }

        public override Shape DeepClone()
        {
            var baseClone = (Rectangle)this.MemberwiseClone();
            baseClone.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return baseClone;
        }
    }
}
