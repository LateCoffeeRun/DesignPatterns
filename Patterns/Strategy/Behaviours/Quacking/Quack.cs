namespace DesignPatterns.Patterns.Strategy.Behaviours.Quacking;

internal class Quack : IQuackBehaviour
{
    void IQuackBehaviour.Quack()
    {
        Console.WriteLine("Quack");
    }
}
