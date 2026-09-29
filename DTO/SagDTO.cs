using Backend_Rider.Models;

namespace Backend_Rider.DTO;

public class SagDTO
{
    public int SagsNummer { get; set; }
    public string Titel { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
    public SagsKategori Kategori { get; set; }
    public int KundeNummer { get; set; }
    public DateTime Oprettet { get; set; }
}