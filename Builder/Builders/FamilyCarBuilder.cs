namespace Builder.Builders;

/// <summary>
/// Builds a family car
/// </summary>
public class FamilyCarBuilder : IVehicleBuilder
{
    public Vehicle Vehicle { get; init; } = new Vehicle("Family Car");

    public IVehicleBuilder SetChassis()
    {
        Vehicle.SetChassis("5 Door");
        return this;
    }

    public IVehicleBuilder SetEngine()
    {
        Vehicle.SetEngine("V6");
        return this;
    }

    public IVehicleBuilder SetWheels()
    {
        Vehicle.SetWheels("Alloy");
        return this;
    }
}
