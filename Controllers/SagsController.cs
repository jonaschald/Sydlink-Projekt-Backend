using Backend_Rider.Data;
using Backend_Rider.DTO;
using Backend_Rider.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Rider.Controllers;

[ApiController]
[Route("api/[controller]")]

public class SagsController : ControllerBase
{
    private SydlinkDbContext _context;
    
    public SagsController(SydlinkDbContext context)
    {
        _context = context;
    }

    [HttpGet("/api/getSager")]
    public ActionResult<List<Sag>> Get()
    {
        return Ok(_context.Sager.ToList());
    }
    
    [HttpGet("{sagId}")]
    public ActionResult<Sag> GetBySagId(int sagId)
    {
        var found = _context.Sager.Find(sagId);
        if (found is null)
        {
            return NotFound();
        }
        return Ok(found);
    }

    [HttpPost]
    public ActionResult<SagDTO> Create(CreateSagDTO dto)
    {
        var sag = new Sag
        {
            Titel = dto.Titel,
            Beskrivelse = dto.Beskrivelse,
            Kategori = dto.Kategoti,
            Oprettet = DateTime.Now
        };

        _context.Sager.Add(sag);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetBySagId), new { SagID = sag.SagId }, toSagDTO(sag));
    }

    private static SagDTO toSagDTO(Sag sag) => new()
    {
        SagId = sag.SagId,
        Titel = sag.Titel,
        Beskrivelse = sag.Beskrivelse,
        Kategori = sag.Kategori,
        Oprettet = sag.Oprettet,
    };
}