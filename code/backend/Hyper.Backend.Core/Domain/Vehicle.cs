
namespace Domain;

public abstract class Vehicle : IEntity {
    public int VehicleId { get; set; }
    public string Color { get; set; } = string.Empty;
    public bool HeadlightsOn { get; set; }
}

