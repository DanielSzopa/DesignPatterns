using FactoryAbstract;
using FactoryAbstract.Mac;
using FactoryAbstract.Windows;

var windows = new WindowsFactory();
var mac = new MacFactory();

var appWindows = new Application(windows);
var appMac = new Application(mac);

appWindows.RenderUI();
appMac.RenderUI();
