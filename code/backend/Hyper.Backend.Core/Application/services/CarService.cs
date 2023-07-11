using Application.interfaces;
using Application.utilities.Exceptions;
using Domain;

namespace Application.services;

public class CarService : ICarService {
    private readonly ICarDal _carDal;
    public CarService(ICarDal carDal) {
        _carDal = carDal;
    }

    public void AddCar(Car car) {
        _carDal.Add(car);
    }

    public void DeleteCar(Guid carId) {
        var result = GetById(carId) ?? throw new CarNotFoundException("Car not found!");
        _carDal.Delete(result);
    }

    public List<Car> GetAll() {
        return _carDal.GetAll().ToList();
    }

    public Car? GetById(Guid carId) {
        return _carDal.GetById(carId);
    }

    public IList<Car> GetCarsByColor(string carColor) {
        return _carDal.GetByColor(carColor);
    }

    public void UpdateCar(Car updateCar) {
        _carDal.Update(updateCar);
    }

    public void TurnOffTheHeadLights(Car car) {
        car.HeadlightsOn = false;
        _carDal.Update(car);
    }

    public void TurnOnTheHeadLights(Car car) {
        car.HeadlightsOn = true;
        _carDal.Update(car);
    }
}
