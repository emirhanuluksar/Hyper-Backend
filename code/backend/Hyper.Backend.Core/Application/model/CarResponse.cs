using System.Text.Json.Serialization;
using Domain;

namespace Application.model;

public class CarResponse {
    [JsonPropertyName("Cars")]
    public List<Car> Cars { get; set; } = new();
    [JsonPropertyName("CarsCount")]
    public int CarsCount { get; set; }

    public static CarResponse Of(List<Car> carList) {
        return new() {
            Cars = carList,
            CarsCount = carList.Count
        };
    }

}
