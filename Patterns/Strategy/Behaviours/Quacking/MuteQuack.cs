namespace DesignPatterns.Patterns.Strategy.Behaviours.Quacking;

internal class MuteQuack : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Silence");
    }
}
