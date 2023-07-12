using Hyper.Common.Web;
using Microsoft.AspNetCore.Mvc;

namespace Hyper.Backend.Web.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    [HttpGet(""), HttpGet("api/[controller]/GetTime")]
    public DateTime GetTime() {
        _logger.LogInformation("HomeController.GetTime() ");
        return DateTime.Now;
    }
}
