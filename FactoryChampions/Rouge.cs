namespace FactoryChampions
{
    public class Rouge : Champion
    {
        public Rouge(string name, int hp, int mana) : base(name, hp, mana)
        {

        }
        public override string UseBaseSkill()
        {
            return "Knife hit";
        }
    }
}
