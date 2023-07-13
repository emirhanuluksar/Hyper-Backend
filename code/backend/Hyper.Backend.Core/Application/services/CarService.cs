using Application.utilities.constants;
using Application.interfaces;
using Application.utilities.Exceptions;
using Domain;
using Application.model;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Application.services;

public class CarService : ICarService {
    public readonly IMapper _mapper;
    private readonly IVehicleDal _vehicleDal;
    private readonly ILogger<CarService> _logger;
    public CarService(IMapper mapper, IVehicleDal vehicleDal, ILogger<CarService> logger) {
        _mapper = mapper;
        _vehicleDal = vehicleDal;
        _logger = logger;
    }

    public Car AddCar(Car car) {
        _vehicleDal.Add(car);
        return car;
    }

    public Car DeleteCar(Guid carId) {
        var result = GetById(carId) ?? throw new CarNotFoundException(Constant.CarNotFound);
        _vehicleDal.Delete(result);
        return _mapper.Map<Car>(result);
    }

    public CarResponse GetAll() {
        var vehicleList = _vehicleDal.GetList(x => x.VehicleType == Constant.CarType).ToList();
        var carList = _mapper.Map<List<Car>>(vehicleList);
        return CarResponse.Of(carList);
    }

    public Car? GetById(Guid carId) {
        var car = _vehicleDal.GetById(carId);
        return _mapper.Map<Car>(car);
    }

    public CarResponse GetCarsByColor(string carColor) {
        var result = _vehicleDal.GetList(x => x.Color == carColor && x.VehicleType == Constant.CarType).ToList();
        var car = _mapper.Map<List<Car>>(result);
        return CarResponse.Of(car);
    }

    public Car UpdateCar(Car updateCar) {
        _vehicleDal.Update(updateCar);
        return updateCar;
    }

    public Car TurnOffTheHeadLights(Car car) {
        car.HeadlightsOn = false;
        var vehicle = _mapper.Map<Vehicle>(car);
        _vehicleDal.Update(vehicle);
        return car;
    }

    public Car TurnOnTheHeadLights(Car car) {
        car.HeadlightsOn = true;
        var vehicle = _mapper.Map<Vehicle>(car);
        _vehicleDal.Update(vehicle);
        return car;
    }

    public List<Vehicle> GetVehicles() {
        return _vehicleDal.GetAll().ToList();
    }
}
