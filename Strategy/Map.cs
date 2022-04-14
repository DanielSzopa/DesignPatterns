namespace Strategy
{
    public class Map : IMap
    {
        private readonly IRouteStrategy _strategy;

        public Map(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CreateRoute(Coordinate start, Coordinate end)
        {
            _strategy.CreateRoute(start, end);
        }
    }
}
