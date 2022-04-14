using Signleton;



var cfg = SqlConfiguration.GetInstance();
cfg.Server = "localhost";
cfg.Database = "ErpDatabase";
cfg.User = "sa";
cfg.Password = "pass";

var cfg2 = SqlConfiguration.GetInstance();

var result = ReferenceEquals(cfg, cfg2);
var resultMessage = result ? "Configuration is Singleton" : "Configuration is not Singleton";
Console.WriteLine(resultMessage);
