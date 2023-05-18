using DesignPatterns.Patterns.Strategy.Behaviours;

namespace DesignPatterns.Patterns.Strategy;

internal abstract class Duck
{
    protected IFlyBehaviour FlyBehaviour;
    protected IQuackBehaviour QuackBehaviour;

    public abstract void Display();

    public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
    {
        FlyBehaviour = flyBehaviour;
    }

    public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
    {
        QuackBehaviour = quackBehaviour;
    }

    public void PerformFly()
    {
        FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        QuackBehaviour.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("Ducks don't swim they float :)");
    }
}
