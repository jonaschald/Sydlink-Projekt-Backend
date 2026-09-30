namespace Backend_Rider.Models
;

public class Besked
{
    public int BeskedId { get; set; }
    public string Titel { get; set; } = string.Empty;
    public int SagsNummer { get; set; }
    public string Beskeden { get; set; } = string.Empty;
    public DateTime Oprettet { get; set; } = DateTime.Now;
    public Sag sag { get; set; } = null!;
    public int? KundeId { get; set; }
    public Kunde? Kunde { get; set; }
    public int? MedarbejderId { get; set; }
    public Medarbejder? Medarbejder { get; set; }
}
