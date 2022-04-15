namespace Fascada
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors,
            IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
        {
            Console.WriteLine($"Quality Scan Errors:   {string.Join(",",qualityScanErrors)}");
            Console.WriteLine($"Security Scan Errors:   {string.Join(",", securityScanErrors)}");
            Console.WriteLine($"Dependency Scan Errors:   {string.Join(",", dependencyScanErrors)}");
        }
    }
}
