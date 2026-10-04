using Backend_Rider.Data;
using Backend_Rider.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Rider.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BeskedController : ControllerBase
{
    private readonly SydlinkDbContext _context;

    public BeskedController(SydlinkDbContext context)
    {
        _context = context;
    }

    // Hent alle beskeder
    [HttpGet]
    public ActionResult<List<Besked>> Get()
    {
        return Ok(_context.Beskeder.ToList());
    }

    // Hent beskeder for en bestemt sag
    [HttpGet("sag/{sagsNummer}")]
    public ActionResult<List<Besked>> GetBySag(int sagsNummer)
    {
        var beskeder = _context.Beskeder
            .Where(x => x.SagsNummer == sagsNummer)
            .OrderBy(x => x.Oprettet)
            .ToList();

        return Ok(beskeder);
    }

    // Opret en besked
    [HttpPost]
    public ActionResult<Besked> Create(Besked besked)
    {
        besked.BeskedId = 0;
        besked.Oprettet = DateTime.Now;

        _context.Beskeder.Add(besked);
        _context.SaveChanges();

        return Ok(besked);
    }
}