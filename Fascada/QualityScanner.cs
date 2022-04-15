namespace Fascada
{
    public class QualityScanner
    {
        public IEnumerable<string> QualityScan(string githubURL)
        {
            Console.WriteLine("Quality scan");

            return new List<string>() { "Error1", "Error2" };
        }
    }
}
