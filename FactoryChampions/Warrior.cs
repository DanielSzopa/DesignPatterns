namespace FactoryChampions
{
    public class Warrior : Champion
    {
        public Warrior(string name, int hp, int mana) : base(name, hp, mana)
        {

        }
        public override string UseBaseSkill()
        {
            return "Warrior charge";
        }
    }
}
