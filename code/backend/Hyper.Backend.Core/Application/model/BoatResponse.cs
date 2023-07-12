using System.Text.Json.Serialization;
using Domain;

namespace Application.model;

public class BoatResponse {
    [JsonPropertyName("Boats")]
    public List<Boat> Boats { get; set; } = new();
    [JsonPropertyName("BoatsCount")]
    public int BoatsCount { get; set; }

    public static BoatResponse Of(List<Boat> boats) {
        return new() {
            Boats = boats,
            BoatsCount = boats.Count
        };
    }
}
