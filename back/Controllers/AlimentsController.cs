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
    [HttpGet("{id}", Name = "GetAliment")]
    public Aliment Get(int id)
    {
            var aliment = Aliment.GetAll().FirstOrDefault(aliment => aliment.Id == id);
            if (aliment == null)
            {
                throw new Exception("Aliment not found");
            }
            return aliment;
    }

    // GET aliments by type
    [HttpGet("type/{type}", Name = "GetAlimentsByType")]
    public IEnumerable<Aliment> Get(string type)
    {
        return Aliment.GetAll()
        .Where(aliment => string.Equals(type, aliment.Type, StringComparison.OrdinalIgnoreCase))
        .ToArray();
    }

}