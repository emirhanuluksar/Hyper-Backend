using Application.interfaces;
using Domain;

namespace Application.DataAccess.Repository;

public class VehicleRepository<T> : IVehicleRepository<T> where T : Vehicle {

    private readonly List<Vehicle> vehicles;

    public VehicleRepository() {
        vehicles = new List<Vehicle>
        {
            new Car { VehicleId = 1, Color = "red", Wheels = 4, Headlights = false },
            new Car { VehicleId = 2, Color = "blue", Wheels = 4, Headlights = true },
            new Car { VehicleId = 3, Color = "black", Wheels = 4, Headlights = false },
            new Car { VehicleId = 4, Color = "white", Wheels = 4, Headlights = true },
            new Boat { VehicleId = 5, Color = "red" },
            new Boat { VehicleId = 6, Color = "blue" },
            new Boat { VehicleId = 7, Color = "black" },
            new Boat { VehicleId = 8, Color = "white" },
            new Bus { VehicleId = 9, Color = "red" },
            new Bus { VehicleId = 10, Color = "blue" },
            new Bus { VehicleId = 11, Color = "black" },
            new Bus { VehicleId = 12, Color = "white" }
        };
    }

    public IEnumerable<T> GetByColor(string color) {
        return vehicles.Where(v => v.Color.Equals(color, StringComparison.OrdinalIgnoreCase)).OfType<T>();
    }

    public void Update(T entity) {
        vehicles[vehicles.FindIndex(v => v.VehicleId == entity.VehicleId)] = entity;
    }
    public void Delete(T entity) {
        vehicles.Remove(entity);
    }

    public T? FindById(int id) {
        return vehicles.Find(v => v.VehicleId == id) as T;
    }
}
