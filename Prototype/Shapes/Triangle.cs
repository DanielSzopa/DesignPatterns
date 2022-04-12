namespace Prototype.Shapes
{
    public class Triangle : Shape
    {
        public override Shape ShallowClone()
        {
            return (Triangle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render Triangle");
        }

        public override Shape DeepClone()
        {
            var baseClone = (Triangle)this.MemberwiseClone();
            baseClone.Border = new Border 
            { 
              Color = Border.Color,
              Size = Border.Size 
            };
            return baseClone;
        }
    }
}
