using Application.interfaces;
using Application.model;
using AutoMapper;
using Domain;
using Hyper.Common.Web;
using Microsoft.AspNetCore.Mvc;


namespace Hyper.Backend.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BoatController : ApiController {
    public readonly IBoatService _boatService;
    public readonly IMapper _mapper;
    private readonly ILogger<BoatController> _logger;

    public BoatController(IBoatService boatService, IMapper mapper, ILogger<BoatController> logger) {
        _boatService = boatService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet("GetBoatsByColor/{color}")]
    public BoatResponse GetBoatsByColor(string color) {
        _logger.LogInformation("BoatController.GetBoatsByColor()");
        return _boatService.GetBoatsByColor(color);
    }

    [HttpGet("GetAll")]
    public BoatResponse GetAll() {
        _logger.LogInformation("BoatController.GetAll()");
        return _boatService.GetAll();
    }

    [HttpGet("GetBoatById/{id:guid}")]
    public Boat? GetBoatById(Guid id) {
        _logger.LogInformation("BoatController.GetBoatById()");
        return _boatService.GetById(id);
    }

    [HttpPost("AddBoat")]
    public IActionResult AddBoat(BoatRequest boatRequest) {
        _logger.LogInformation("BoatController.AddBoat()");
        var boat = _mapper.Map<Boat>(boatRequest);
        return HandleErrors(() => _boatService.AddBoat(boat));
    }

    [HttpPut("UpdateBoat")]
    public Boat UpdateBoat([FromBody] Boat updateBoat) {
        _logger.LogInformation("BoatController.UpdateBoat()");
        _boatService.UpdateBoat(updateBoat);
        return updateBoat;
    }

    [HttpDelete("DeleteBoat/{id:guid}")]
    public IActionResult DeleteBoat(Guid id) {
        _logger.LogInformation("BoatController.DeleteBoat()");
        return HandleErrors(() => _boatService.DeleteBoat(id));
    }
}

