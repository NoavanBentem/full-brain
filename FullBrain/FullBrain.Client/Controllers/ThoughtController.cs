using FullBrain.Client.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FullBrain.Client.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThoughtController : ControllerBase
{
    static private List<Thought> thoughts = new List<Thought>
    {
        new Thought
        {
            Id = 1,
            Text = "Thought 1"
        },
        new Thought
        {
            Id = 2,
            Text = "Thought 2"
        }
    };

    [HttpGet]
    public ActionResult<List<Thought>> GetThought()
    {
        return Ok(thoughts);
    }
}
