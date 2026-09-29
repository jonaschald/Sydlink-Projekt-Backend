namespace Backend_Rider.Models;

public class Sag
{
    public int SagsNummer { get; set; }
    public string Titel { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
    public SagsKategori Kategori { get; set; }
    public SagsStatus Status { get; set; }
    public int KundeNummer { get; set; }
    public Kunde? Kunde { get; set; }
    public DateTime Oprettet { get; set; } = DateTime.Now;
    public Medarbejder? Medarbejder { get; set; } 
    public SagsPrioritet Prioritet { get; set; }
}

public enum SagsKategori
{
    Internet,
    Fiber,
    WiFi,
    Router,
    Fakturering,
    Andet
}

public enum SagsStatus
{
    Ny,
    UnderBehandling,
    AfventerKunden,
    Løst,
    Lukket
}

public enum SagsPrioritet
{
    Haster,
    Normal,
    KanVente
}