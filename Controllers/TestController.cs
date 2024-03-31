using Microsoft.AspNetCore.Mvc;

namespace VueHotReload.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return Ok("Hello World!");
    }
}