using System.Text.Json.Serialization;
using Domain;

namespace Application.model;

public class BusResponse {
    [JsonPropertyName("Buses")]
    public List<Bus> Buses { get; set; } = new();
    [JsonPropertyName("BusesCount")]
    public int BusesCount { get; set; }

    public static BusResponse Of(List<Bus> buses) {
        return new() {
            Buses = buses,
            BusesCount = buses.Count
        };
    }
}
