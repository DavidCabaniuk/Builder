namespace Builder.Builders;

/// <summary>
/// Builds a sports car
/// </summary>
public class SportsCarBuilder : IVehicleBuilder
{
    public Vehicle Vehicle { get; init; } = new Vehicle("Family Car");

    public IVehicleBuilder SetChassis()
    {
        Vehicle.SetChassis("Sports 5 Door");
        return this;
    }

    public IVehicleBuilder SetEngine()
    {
        Vehicle.SetEngine("V8");
        return this;
    }

    public IVehicleBuilder SetWheels()
    {
        Vehicle.SetWheels("Sports Alloy");
        return this;
    }
}
