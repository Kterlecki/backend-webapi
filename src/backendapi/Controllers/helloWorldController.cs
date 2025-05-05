

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend_api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    /// <summary>
    /// XML documentation for the HelloWorldController.
    /// Should give back Hello world
    /// </summary>
    [HttpGet(Name = "GetHelloWorld")]
    public string Get()
    {
        return "Hello World!";
    }

    [Authorize]
    [HttpGet("secure", Name = "GetSecureHelloWorld")]
    public string GetSecure()
    {
        return "Hello Secure World!";
    }
}

