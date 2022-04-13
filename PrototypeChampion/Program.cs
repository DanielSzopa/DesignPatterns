using PrototypeChampion;

var armor = new Armor() { ArmorName = "Lion armor", Strength = 100 };
var mag = new Mag("Neeko", 100, armor);

var mag2 = mag.Clone();


Console.WriteLine(mag.ToString());
Console.WriteLine("\n");
Console.WriteLine(mag2.ToString());


var cloneResult = ReferenceEquals(mag, mag2);

var result = cloneResult ? "ShallowClone" : "DeepClone";

Console.WriteLine();
Console.WriteLine(result);
