namespace FactoryChampions
{
    public class Mag : Champion
    {
        public Mag(string name, int hp, int mana) : base(name, hp, mana)
        {

        }

        public override string UseBaseSkill()
        {
            return "Fire ball";
        }
    }
}
