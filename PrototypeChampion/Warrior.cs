namespace PrototypeChampion
{
    public class Warrior : Champion
    {
        public Warrior(string name, int hp, Armor armor) : base(name, hp, armor)
        {

        }
        public override Champion Clone()
        {
            var baseClone = (Warrior)this.MemberwiseClone();
            baseClone.Armor = new Armor
            { ArmorName = Armor.ArmorName, Strength = Armor.Strength };
            return baseClone;
        }
    }
}
