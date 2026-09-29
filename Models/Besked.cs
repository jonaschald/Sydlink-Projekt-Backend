namespace Backend_Rider.Models
;

public class Besked
{
    public string Titel { get; set; } = string.Empty;
    public string Beskeden { get; set; } = string.Empty;
    public DateTime Oprettet { get; set; } = DateTime.Now;
}