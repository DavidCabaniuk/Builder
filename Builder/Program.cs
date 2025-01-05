using Builder;
using Builder.Builders;

IVehicleBuilder builder;

// Only one director is needed because all vehicles are setup in the same way.
VehicleDirector vehicleDirector = new();

// Use the director to construct a family car through the family car builder.
builder = new FamilyCarBuilder();
vehicleDirector.Construct(builder);
builder.Vehicle.ShowDetails();

// Use the director to construct a sports car through the family car builder.
builder = new SportsCarBuilder();
vehicleDirector.Construct(builder);
builder.Vehicle.ShowDetails();