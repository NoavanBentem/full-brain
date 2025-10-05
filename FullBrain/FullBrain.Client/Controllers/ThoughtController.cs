using FullBrain.Client.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FullBrain.Client.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThoughtController : ControllerBase
{
    static private List<ThoughtModel> thoughts = new List<ThoughtModel>
    {
        new ThoughtModel
        {
            Id = 1,
            Text = "Thought 1"
        },
        new ThoughtModel
        {
            Id = 2,
            Text = "Thought 2"
        }
    };

    [HttpGet]
    public ActionResult<List<ThoughtModel>> GetThought()
    {
        return Ok(thoughts);
    }
}
