using Microsoft.AspNetCore.Mvc;
using back.Models;
namespace back.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlimentsController : ControllerBase
{
    
    [HttpGet(Name = "GetAliments")]
    public IEnumerable<Aliment> Get()
    {
        return Aliment.GetAll()
        .ToArray();
    }
}