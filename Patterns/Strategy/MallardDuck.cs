using DesignPatterns.Patterns.Strategy.Behaviours.Flying;
using DesignPatterns.Patterns.Strategy.Behaviours.Quacking;

namespace DesignPatterns.Patterns.Strategy;
internal class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehaviour = new Squeak();
        FlyBehaviour = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("Displays a duck :D");
    }
}
