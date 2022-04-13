namespace FactoryChampions
{
    public class ChampionFactory : IChampionFactory
    {
        public Champion CreateChampion(string name, int hp, int mana, ChampionTypes type)
        {
            switch (type)
            {
                case ChampionTypes.Mag:
                    return new Mag(name, hp, mana);

                case ChampionTypes.Warrior:
                    return new Warrior(name, hp, mana);

                case ChampionTypes.Rouge:
                    return new Rouge(name, hp, mana);

                default:
                    throw new Exception($"Type {type} is wrong");
            }
        }
    }
}
