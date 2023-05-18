using DesignPatterns.Patterns.Strategy.Behaviours;

namespace DesignPatterns.Patterns.Strategy.Behaviours.Flying;

internal class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings");
    }
}
