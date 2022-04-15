namespace Fascada
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubURL)
        {
            Console.WriteLine("Dependency Scan");

            return new List<string>() { "Dependency scan error1" };
        }
    }
}
