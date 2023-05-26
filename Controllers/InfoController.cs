using AzureDevopsPipelineAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsPipelineAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InfoController : ControllerBase
{

    private readonly ILogger<InfoController> _logger;

    public InfoController(ILogger<InfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Info Get()
    {
        return new Info(){
            EnvName = "Teste",
            FrameworkDescription = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
            MachineName = System.Environment.MachineName,
            OSVersion = System.Environment.OSVersion.Version.ToString()
        };
    }
}
