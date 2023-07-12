namespace Domain;
public class Vehicle {
    public string VehicleType { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public int Length { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
}

