using Application.interfaces;
using Application.model;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Application.services;

public class VehicleService : IVehicleService {
    public readonly IMapper _mapper;
    private readonly IVehicleDal _vehicleDal;
    private readonly ILogger<VehicleService> _logger;

    public VehicleService(IMapper mapper, IVehicleDal vehicleDal, ILogger<VehicleService> logger) {
        _mapper = mapper;
        _vehicleDal = vehicleDal;
        _logger = logger;
    }
    public VehicleResponse GetAllVehicles() {
        _logger.LogInformation("VehicleService.GetAllVehicles()");
        var vehicleList = _vehicleDal.GetAll().ToList();
        return VehicleResponse.Of(vehicleList);
    }
}
