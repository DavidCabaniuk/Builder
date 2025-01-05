namespace Builder.Builders;

/// <summary>
/// Interface to determine the configuration sets that must be implemented for a vehicle builder
/// </summary>
public interface IVehicleBuilder
{
    Vehicle Vehicle { get; }

    IVehicleBuilder SetChassis();
    IVehicleBuilder SetEngine();
    IVehicleBuilder SetWheels();
}
