namespace Signleton
{
    public class SqlConfiguration
    {
        private static SqlConfiguration? _instance = null;
        private static object objLock = new object();

        public string? Server { get; set; }
        public string? Database { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }

        private SqlConfiguration()
        {

        }

        public static SqlConfiguration GetInstance()
        {
            lock(objLock)
            {
                if (_instance is null)
                {
                    _instance = new SqlConfiguration();
                }
            }
           
            return _instance;
        }
    }
}
