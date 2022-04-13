using FactoryChampions;

IChampionFactory championFactory = new ChampionFactory();

var champions = new List<Champion>();

var mag = championFactory.CreateChampion("Ahri", 100, 100, ChampionTypes.Mag);
var warrior = championFactory.CreateChampion("Garen", 150, 0, ChampionTypes.Warrior);
var rouge = championFactory.CreateChampion("Shaco", 80, 30, ChampionTypes.Rouge);

champions.Add(mag);
champions.Add(warrior);
champions.Add(rouge);

foreach (var champion in champions)
{
    Console.WriteLine(champion.ToString());
    Console.WriteLine($"Skill: {champion.UseBaseSkill()}");
    Console.WriteLine();
}