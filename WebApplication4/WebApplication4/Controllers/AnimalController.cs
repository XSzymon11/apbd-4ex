using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimalController : ControllerBase
{
    private static List<Animal> _animals = Database.Animals.ToList();
    
    #region GET
    
    [HttpGet]
    public IActionResult GetAllAnimals()
    {
        return Ok(_animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == id);

        if (animal == null)
        {
            return NotFound();
        }
        
        return Ok(animal);
    }
    
    [HttpGet("search")]
    public IActionResult GetAnimal(string name)
    {
        var animal = _animals.FirstOrDefault(a => a.Name == name);
        
        return Ok(animal);
    }
    
    #endregion
    
    #region POST
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        
        return Ok(_animals);
    }
    
    #endregion

    #region PUT
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var oldAnimal = _animals.FirstOrDefault(a => a.Id == id);

        if (oldAnimal == null)
        {
            return NotFound();
        }

        oldAnimal.Name = animal.Name;
        oldAnimal.Category = animal.Category;
        oldAnimal.Weight = animal.Weight;
        oldAnimal.HairColor = animal.HairColor;
        
        return Ok(_animals);
    }

    #endregion
    
    #region DELETE
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        if (!_animals.Any(a => a.Id == id))
            return NotFound();
        
        _animals.Remove(_animals.FirstOrDefault(a => a.Id == id));
        
        return Ok(_animals);
    }
    
    #endregion
    
}