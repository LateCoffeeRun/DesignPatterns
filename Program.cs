using DesignPatterns.Patterns.Strategy;
using DesignPatterns.Patterns.Strategy.Behaviours.Flying;

var duckTest = new MallardDuck();
duckTest.PerformQuack();
duckTest.PerformFly();

duckTest.SetFlyBehaviour(new FlyRocketPowered());
duckTest.PerformFly();

duckTest.Display();


Console.ReadKey();