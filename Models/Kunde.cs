namespace Backend_Rider.Models;

public class Kunde
{
    public int KundeId { get; set; }
    public string Navn { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Kodeord {get; set;} = string.Empty;

    public ICollection<Sag> Sager {get; set;} = [];
    public ICollection<Besked> Beskeder {get; set;} = [];
}
