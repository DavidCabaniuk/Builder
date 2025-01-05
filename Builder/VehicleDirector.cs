using Builder.Builders;

namespace Builder;

public class VehicleDirector
{
    /// <summary>
    /// Construct a vehicle using a step by step process
    /// </summary>
    /// <param name="builder">The specific vehcile builder that the director will produce a vehicle with</param>
    public void Construct(IVehicleBuilder builder)
    {
        Console.WriteLine("Vehicle director constructing a vehicle...");

        builder
            .SetChassis()
            .SetEngine()
            .SetWheels();
    }
}