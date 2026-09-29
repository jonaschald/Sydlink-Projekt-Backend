using System.ComponentModel.DataAnnotations;
using Backend_Rider.Models;

namespace Backend_Rider.DTO;

public class CreateSagDTO
{
    [Required, MaxLength(200)]
    public string Titel { get; set; } = string.Empty;
    
    [Required, MaxLength(4200)]
    public string Beskrivelse { get; set; } = string.Empty;
    
    [Required]
    public SagsKategori Kategoti  { get; set; }
    
    [Required]
    public int KundeNummer { get; set; }
}