using Backend_Rider.Data;
using Backend_Rider.DTO;
using Backend_Rider.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Rider.Controllers;

public class SagsController : ControllerBase
{
    private SydlinkDbContext _context;
    
    public SagsController(SydlinkDbContext context)
    {
        _context = context;
    }

    [HttpGet("{sagsNummer}")]
    public ActionResult<Sag> GetBySagsNummer(int sagsNummer)
    {
        var found = _context.Sager.Find(sagsNummer);
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

        _context.Sag.Add(Sag);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetBySagsNummer), new { SagsNummer = sag.SagsNummer }, toSagDTO(sag));
    }
    
    private static SagDTO toSagDTO(Sag sag) => new()
    {
        SagsNummer = sag.SagsNummer,
        Titel = sag.Titel,
        Beskrivelse = sag.Beskrivelse,
        Kategori = sag.Kategori,
        Oprettet = sag.Oprettet,
    };
}