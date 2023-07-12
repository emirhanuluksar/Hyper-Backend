namespace Application.model;

public record BoatRequest(string VehicleType, string Color, int Capacity, int Length) {
    public BoatRequest() : this("Boat", "", 0, 0) { }
}
