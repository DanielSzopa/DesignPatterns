namespace FactoryChampions
{
    public interface IChampionFactory
    {
        Champion CreateChampion(string name, int hp, int mana, ChampionTypes type);
    }
}