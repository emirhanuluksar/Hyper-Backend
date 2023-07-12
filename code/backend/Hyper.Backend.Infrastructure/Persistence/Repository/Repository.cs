using System.Linq.Expressions;
using Application.interfaces;
using AutoMapper;
using Domain;

namespace Persistence.Repository;

public class Repository<T> : IRepository<T> where T : Vehicle {
    private static readonly List<Vehicle> _vehicles = new() {
            new Car { VehicleType = "Car", Color = "red", Wheels = 4, HeadlightsOn = false, Capacity = 4, Length = 2 },
            new Car { VehicleType = "Car", Color = "blue", Wheels = 4, HeadlightsOn = true, Capacity = 4, Length = 2 },
            new Car { VehicleType = "Car", Color = "black", Wheels = 4, HeadlightsOn = true, Capacity = 8, Length = 2 },
            new Car { VehicleType = "Car", Color = "white", Wheels = 4, HeadlightsOn = false, Capacity = 5, Length = 2 },
            new Bus { VehicleType = "Bus",  Color = "red", Capacity = 30, Length = 4 },
            new Bus { VehicleType = "Bus",  Color = "blue", Capacity = 30, Length = 4 },
            new Bus { VehicleType = "Bus",  Color = "black", Capacity = 45, Length = 5 },
            new Bus { VehicleType = "Bus",  Color = "white", Capacity = 50, Length = 6 },
            new Boat { VehicleType = "Boat",  Color = "red", Capacity = 200, Length = 8 },
            new Boat { VehicleType = "Boat",  Color = "blue", Capacity = 300, Length = 10 },
            new Boat { VehicleType = "Boat",  Color = "black", Capacity = 3000, Length = 200},
            new Boat { VehicleType = "Boat",  Color = "white", Capacity = 5000, Length = 500 }
    };

    public void Add(T entity) {
        _vehicles.Add(entity);
    }

    public void Delete(T entity) {
        _vehicles.Remove(entity);
    }

    public T? Get(Expression<Func<T, bool>> filter) {
        return _vehicles.OfType<T>().SingleOrDefault(filter.Compile());
    }

    public IList<T> GetAll() {
        return _vehicles.OfType<T>().ToList();
    }

    public T? GetById(Guid id) {
        return _vehicles.OfType<T>().SingleOrDefault(x => x.Id == id);
    }

    public IList<T> GetList(Expression<Func<T, bool>>? filter = null) {
        return filter == null ? _vehicles.OfType<T>().ToList() : _vehicles.OfType<T>().Where(filter.Compile()).ToList();
    }

    public void Update(T entity) {
        var index = _vehicles.FindIndex(x => x.Id == entity.Id);
        _vehicles[index] = entity;
    }
}
