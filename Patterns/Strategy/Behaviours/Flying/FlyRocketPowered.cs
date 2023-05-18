namespace DesignPatterns.Patterns.Strategy.Behaviours.Flying;
internal class FlyRocketPowered : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Flying powered by a rocket");
    }
}
