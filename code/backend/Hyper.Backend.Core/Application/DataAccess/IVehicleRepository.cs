using Domain;

namespace Application.interfaces;

public interface IVehicleRepository<T> where T : Vehicle {
    IEnumerable<T> GetByColor(string color);
    void Update(T entity);
    void Delete(T entity);
    T? FindById(int id);

}
