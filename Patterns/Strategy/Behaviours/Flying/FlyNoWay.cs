using DesignPatterns.Patterns.Strategy.Behaviours;

namespace DesignPatterns.Patterns.Strategy.Behaviours.Flying;

internal class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Cannot fly");
    }
}
