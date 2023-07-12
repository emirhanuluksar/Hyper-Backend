using Application.model;
using Domain;

namespace Application.interfaces;

public interface ICarService {
    public Car AddCar(Car car);
    public Car UpdateCar(Car updateCar);
    public Car DeleteCar(Guid carId);
    public CarResponse GetCarsByColor(string carColor);
    public Car? GetById(Guid carId);
    public CarResponse GetAll();
    public Car TurnOnTheHeadLights(Car car);
    public Car TurnOffTheHeadLights(Car car);
}
