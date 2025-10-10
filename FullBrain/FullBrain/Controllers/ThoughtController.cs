using FullBrain.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FullBrain.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThoughtController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<ThoughtModel>> GetThought()
    {
        List<ThoughtModel> thoughts = new List<ThoughtModel>();
        return Ok(thoughts);
    }
}
