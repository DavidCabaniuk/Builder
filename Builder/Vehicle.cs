namespace Builder;

public class Vehicle(string type)
{
    public string Type { get; init; } = type;
    public string? Engine { get; private set; }
    public string? Chassis { get; private set; }
    public string? Wheels { get; private set; }

    public void SetEngine(string engine) => Engine = engine;
    public void SetChassis(string chassis) => Chassis = chassis;
    public void SetWheels(string wheels) => Wheels = wheels;

    /// <summary>
    /// Get the details of what this vehicle has been setup with
    /// </summary>
    public void ShowDetails()
    {
        Console.WriteLine($"Vehicle Type: {Type}");
        Console.WriteLine($" Chassis : {Chassis}");
        Console.WriteLine($" Engine : {Engine}");
        Console.WriteLine($" Wheels: {Wheels}");
    }
}
