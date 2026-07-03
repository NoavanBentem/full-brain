using FullBrain.Data;
using FullBrain.Models;
using Microsoft.EntityFrameworkCore;

namespace FullBrain.Services;

public class ChecklistService
{
    private readonly AppDbContext _db;

    public ChecklistService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Checklist>> GetChecklistsAsync()
    {
        return await _db.Checklists.ToListAsync();
    }
}