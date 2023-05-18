namespace DesignPatterns.Patterns.Strategy.Behaviours.Quacking;
internal class Squeak : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
