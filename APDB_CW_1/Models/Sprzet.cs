using APDB_CW_1.Enums;
using APDB_CW_1.Services;

namespace APDB_CW_1.Models;

public abstract class Sprzet(string nazwaSprzet, string opisSprzet)
{
   public string sprzetID { get; set; } = GenerateID.generate(7);
   public string nazwaSprzet { get; set; } = nazwaSprzet;
   public string opisSprzet { get; set; } = opisSprzet;
   public Availibility dostepnosc { get; set; } = Availibility.AVAILABLE;
}