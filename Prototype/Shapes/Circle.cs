namespace Prototype.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape ShallowClone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render Circle");
        }

        public override Shape DeepClone()
        {
            var baseClone = (Circle)this.MemberwiseClone();
            baseClone.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return baseClone;
        }
    }
}
