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
        return Enumerable.Range(1, 5).Select((index)=> new Recipe
        {
            Name = "Recipe " + index,
            Description = "This is a description for recipe " + index,
            Ingredients = "This is a list of ingredients for recipe " + index,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        })
        .ToArray();
    }
}
