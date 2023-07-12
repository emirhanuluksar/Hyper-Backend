using System.Text.Json.Serialization;
using Domain;

namespace Application.model;

public class VehicleResponse {
    [JsonPropertyName("Vehicles")]
    public List<Vehicle> Vehicles { get; set; } = new();
    [JsonPropertyName("VehiclesCount")]
    public int VehiclesCount { get; set; }

    public static VehicleResponse Of(List<Vehicle> vehicleList) {
        return new() {
            Vehicles = vehicleList,
            VehiclesCount = vehicleList.Count
        };
    }
}
