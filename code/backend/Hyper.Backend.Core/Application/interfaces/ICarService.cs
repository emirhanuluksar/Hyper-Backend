using Domain;

namespace Application.interfaces;

public interface ICarService {
    public void AddCar(Car car);
    public void UpdateCar(Car updateCar);
    public void DeleteCar(Guid carId);
    public IList<Car> GetCarsByColor(string carColor);
    public Car? GetById(Guid carId);
    public List<Car> GetAll();
}
