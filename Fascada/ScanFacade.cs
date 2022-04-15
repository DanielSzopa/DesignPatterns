namespace Fascada
{
    public class ScanFacade
    {
        private QualityScanner _qualityScanner = new();
        private SecurityScanner _securityScanner = new();
        private DependencyScanner _dependencyScanner = new();
        private ReportGenerator _reportGenerator = new();
        public void Scan(string githubUrl)
        {
            var quailityScanErrors = _qualityScanner.QualityScan(githubUrl);
            var securityScanErrors = _securityScanner.SecurityScan(githubUrl);
            var dependencyScanErrors = _dependencyScanner.DependencyScan(githubUrl);

            Console.WriteLine("Scan report:");
            Console.WriteLine($"Github Url: {githubUrl} \n");

            _reportGenerator.GenerateReport(quailityScanErrors,securityScanErrors,dependencyScanErrors);
        }
    }
}
