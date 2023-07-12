using Application.interfaces;
using Application.model;
using AutoMapper;
using Domain;
using Hyper.Common.Web;
using Microsoft.AspNetCore.Mvc;


namespace Hyper.Backend.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarController : ApiController {
    public readonly ICarService _carService;
    public readonly IMapper _mapper;
    private readonly ILogger<CarController> _logger;

    public CarController(ICarService carService, IMapper mapper, ILogger<CarController> logger) {
        _carService = carService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet("GetCarsByColor/{color}")]
    public CarResponse GetCarsByColor(string color) {
        _logger.LogInformation("CarController.GetCarsByColor()");
        return _carService.GetCarsByColor(color);
    }

    [HttpGet("GetAll")]
    public CarResponse GetAll() {
        _logger.LogInformation("CarController.GetAll()");
        return _carService.GetAll();
    }

    [HttpGet("GetCarById/{id:guid}")]
    public Car? GetCarById(Guid id) {
        _logger.LogInformation("CarController.GetCarById()");
        return _carService.GetById(id);
    }

    [HttpPost("AddCar")]
    public IActionResult AddCar(CarRequest carRequest) {
        _logger.LogInformation("CarController.AddCar()");
        var car = _mapper.Map<Car>(carRequest);
        return HandleErrors(() => _carService.AddCar(car));
    }

    [HttpPut("UpdateCar")]
    public Car UpdateCar([FromBody] Car updateCar) {
        _logger.LogInformation("CarController.UpdateCar()");
        _carService.UpdateCar(updateCar);
        return updateCar;
    }

    [HttpDelete("DeleteCar/{id:guid}")]
    public IActionResult DeleteCar(Guid id) {
        _logger.LogInformation("CarController.DeleteCar()");
        return HandleErrors(() => _carService.DeleteCar(id));
    }

    [HttpPut("TurnOnTheHeadLights")]
    public Car TurnOnTheHeadLights(Car car) {
        _logger.LogInformation("CarController.TurnOnTheHeadLights()");
        return _carService.TurnOnTheHeadLights(car);
    }

    [HttpPut("TurnOffTheHeadLights")]
    public Car TurnOffTheHeadLights(Car car) {
        _logger.LogInformation("CarController.TurnOffTheHeadLights()");
        return _carService.TurnOffTheHeadLights(car);
    }
}

