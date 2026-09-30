using Backend_Rider.Models;

namespace Backend_Rider.Data;

public class SeedData
{
  public static void Initialize(SydlinkDbContext context)
  {
    if (context.Kunder.Any()) return;
    context.Kunder.AddRange
    (
      new Kunde
      {
        Navn = "Søren Sørensen",
        Email = "Soren.S@gmail.com",
        Kodeord = "TestKunde1"
      },
      
      new Kunde
      {
        Navn = "Olga hansen",
        Email = "OlgaHansen@mail.dk",
        Kodeord = "TestKunde2"
      }
    );
    
    if (context.Sager.Any()) return;
    context.Sager.AddRange
    (
      new Sag
      {
        Titel = "Langsomt internet", 
        Beskrivelse = "mit internet er langsomt, og jeg kan ikke bruge det",
        Kategori = SagsKategori.Internet,
        KundeId = 1
      },
      
      new Sag
      {
        Titel = "Manglende fakturering",
        Beskrivelse = "Hej Sydlink, Jeg mangler min fakturering for betaling for denne måden, håber i kan hjæpe. Venlig hilsen Olga",
        Kategori = SagsKategori.Fakturering,
        KundeId = 2
      }
    );

    if (context.Medarbejdere.Any()) return;
    context.Medarbejdere.AddRange
    (
      new Medarbejder
      {
        Navn = "Lise Nilsen",
        Email = "Lise@Sydlink.dk",
        Kodeord = "TestMedarbejdere1"
      }
    );
    context.SaveChanges();
  }

}
