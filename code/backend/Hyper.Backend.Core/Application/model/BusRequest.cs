namespace Application.model;

public record BusRequest(string VehicleType, string Color, int Capacity, int Length) {
    public BusRequest() : this("Bus", "", 0, 0) { }
}
