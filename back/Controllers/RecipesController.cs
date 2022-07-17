using Microsoft.AspNetCore.Mvc;
using back.Models;
namespace back.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipesController : ControllerBase
{
    
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Recipe> Get()
    {
     return Recipe.GetAll();
    }
}
