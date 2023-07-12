using Application.interfaces;
using Application.model;
using AutoMapper;
using Domain;
using Hyper.Common.Web;
using Microsoft.AspNetCore.Mvc;


namespace Hyper.Backend.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VehicleController : ApiController {
    public readonly IVehicleService _vehicleService;
    public readonly IMapper _mapper;
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(IVehicleService vehicleService, IMapper mapper, ILogger<VehicleController> logger) {
        _vehicleService = vehicleService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet("GetAllVehicles")]
    public VehicleResponse GetAllVehicles() {
        _logger.LogInformation("VehicleController.GetAllVehicles()");
        return _vehicleService.GetAllVehicles();
    }
}

