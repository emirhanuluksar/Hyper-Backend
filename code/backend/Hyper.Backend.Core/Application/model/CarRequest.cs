namespace Application.model;

public record CarRequest(string VehicleType, string Color, int Wheels, bool HeadlightsOn, int Capacity, int Length) {
    public CarRequest() : this("Car", "", 0, false, 0, 0) { }
}

