using Decorator;

var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
var doubleCheesePizza = new CheesePizzaDecorator(mediumPizzaWithCheese);
var doubleCheeseWithSalamiPizza = new SalamiPizzaDecorator(doubleCheesePizza);

Console.WriteLine(pizzaBase.CalculatePrice());
Console.WriteLine(mediumPizzaWithCheese.CalculatePrice());
Console.WriteLine(doubleCheesePizza.CalculatePrice());
Console.WriteLine(doubleCheeseWithSalamiPizza.CalculatePrice());