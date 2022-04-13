namespace FactoryChampions
{
    public abstract class Champion
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public string? Name { get; set; }
        public Champion(string name, int hp, int mana)
        {
            Name = name;
            Hp = hp;
            Mana = mana;
        }
        public abstract string UseBaseSkill();

        public override string ToString()
        {
            return $"Name: {Name} | Hp: {Hp} | Mana: {Mana}";
        }
    }
}
