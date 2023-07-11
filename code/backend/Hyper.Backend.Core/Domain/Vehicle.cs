namespace Domain;
public class Vehicle : IEntity {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Color { get; set; } = string.Empty;
}

