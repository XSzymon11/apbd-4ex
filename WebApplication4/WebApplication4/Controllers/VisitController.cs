using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers;

[ApiController]
[Route("api/[controller]/{animalId:int}")]
public class VisitController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Visit>> GetVisits(int animalId)
    {
        if (Database.Animals.All(a => a.Id != animalId))
            return NotFound();
        
        var anymals = Database.Visits
            .Where(a => a.AnimalId == animalId)
            .ToList();
        
        return Ok(anymals);
    }
    
    [HttpPost]
    public ActionResult<Visit> Create([FromRoute] int animalId, Visit newVisit)
    {
        if (Database.Animals.All(a => a.Id != animalId))
            return NotFound();
        
        newVisit.AnimalId = animalId;
        Database.Visits.Add(newVisit);

        return Ok(newVisit);
    }
}