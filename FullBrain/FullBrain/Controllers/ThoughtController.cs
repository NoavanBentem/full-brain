using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullBrain.Data;
using FullBrain.Models; 

namespace FullBrain.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThoughtController : ControllerBase
{
    private readonly AppDbContext _context;

    public ThoughtController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ThoughtModel>>> GetThoughts()
    {
        return await _context.Thoughts.ToListAsync();
    }

    
    public ActionResult<List<ThoughtModel>> GetThought()
    {
        List<ThoughtModel> thoughts = new List<ThoughtModel>();
        return Ok(thoughts);
    }
}
