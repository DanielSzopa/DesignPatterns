namespace PrototypeChampion
{
    public class Mag : Champion
    {
        public Mag(string name, int hp, Armor armor) : base(name, hp, armor)
        {

        }
        public override Champion Clone()
        {
            var baseClone = (Mag)this.MemberwiseClone();
            baseClone.Armor = new Armor
            { ArmorName = Armor.ArmorName, Strength = Armor.Strength };
            return baseClone;
        }
    }
}
