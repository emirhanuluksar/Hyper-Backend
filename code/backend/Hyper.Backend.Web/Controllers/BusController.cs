using Application.interfaces;
using Application.model;
using AutoMapper;
using Domain;
using Hyper.Common.Web;
using Microsoft.AspNetCore.Mvc;


namespace Hyper.Backend.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BusController : ApiController {
    public readonly IBusService _busService;
    public readonly IMapper _mapper;
    private readonly ILogger<BusController> _logger;

    public BusController(IBusService busService, IMapper mapper, ILogger<BusController> logger) {
        _busService = busService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet("GetBusesByColor/{color}")]
    public BusResponse GetBusesByColor(string color) {
        _logger.LogInformation("BusController.GetCarsByColor()");
        return _busService.GetBusesByColor(color);
    }

    [HttpGet("GetAll")]
    public BusResponse GetAll() {
        _logger.LogInformation("BusController.GetAll()");
        return _busService.GetAll();
    }

    [HttpGet("GetBusById/{id:guid}")]
    public Bus? GetBusById(Guid id) {
        _logger.LogInformation("BusController.GetBusById()");
        return _busService.GetById(id);
    }

    [HttpPost("AddBus")]
    public IActionResult AddBus(BusRequest busRequest) {
        _logger.LogInformation("BusController.AddBus()");
        var bus = _mapper.Map<Bus>(busRequest);
        return HandleErrors(() => _busService.AddBus(bus));
    }

    [HttpPut("UpdateBus")]
    public Bus UpdateBus([FromBody] Bus updateBus) {
        _logger.LogInformation("BusController.UpdateBus()");
        _busService.UpdateBus(updateBus);
        return updateBus;
    }

    [HttpDelete("DeleteBus/{id:guid}")]
    public IActionResult DeleteBus(Guid id) {
        _logger.LogInformation("BusController.DeleteBus()");
        return HandleErrors(() => _busService.DeleteBus(id));
    }
}

