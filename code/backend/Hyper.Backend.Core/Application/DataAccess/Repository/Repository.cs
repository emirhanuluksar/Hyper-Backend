using System.Linq.Expressions;
using Domain;

namespace Application.DataAccess.Repository;

public class Repository<T> : IRepository<T> where T : Vehicle, IEntity, new() {
    private static readonly List<Vehicle> _vehicles = new() {
            new Car { Id = Guid.NewGuid(), Color = "red", Wheels = 4, HeadlightsOn = false },
            new Car { Id = Guid.NewGuid(), Color = "blue", Wheels = 4, HeadlightsOn = true },
            new Car { Id = Guid.NewGuid(), Color = "black", Wheels = 4, HeadlightsOn = true },
            new Car { Id = Guid.NewGuid(), Color = "white", Wheels = 4, HeadlightsOn = false },
            new Bus { Id = Guid.NewGuid(), Color = "red" },
            new Bus { Id = Guid.NewGuid(), Color = "blue" },
            new Bus { Id = Guid.NewGuid(), Color = "black" },
            new Bus { Id = Guid.NewGuid(), Color = "white" },
            new Boat { Id = Guid.NewGuid(), Color = "red" },
            new Boat { Id = Guid.NewGuid(), Color = "blue" },
            new Boat { Id = Guid.NewGuid(), Color = "black" },
            new Boat { Id = Guid.NewGuid(), Color = "white" }
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

    public IList<T> GetByColor(string color) {
        return _vehicles.OfType<T>().Where(car => car.Color == color).ToList();
    }

    public T? GetById(Guid id) {
        return _vehicles.OfType<T>().SingleOrDefault(x => x.Id == id);
    }

    public void Update(T entity) {
        var index = _vehicles.FindIndex(x => x.Id == entity.Id);
        _vehicles[index] = entity;
    }
}
