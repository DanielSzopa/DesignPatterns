namespace PrototypeChampion
{
    public abstract class Champion
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public Armor Armor { get; set; }

        public Champion(string name, int hp, Armor armor)
        {
            Name = name;
            Hp = hp;
            Armor = armor;
        }

        public abstract Champion Clone();

        public override string ToString()
        {
            var result = $"{Name} | Hp: {Hp} | Armor: {Armor.ArmorName}/{Armor.Strength}";
            return result;
        }
    }
}
