using System.Runtime.CompilerServices;

namespace APDB_CW_1.Models;

public class Wypozyczenie(User client, Sprzet rentedGear, int howManyDays)
{
    public User client { get; set; } = client;
    public Sprzet rentedGear { get; set; } = rentedGear;
    public int howManyDays { get; set; } = howManyDays;
    public DateTime startDate { get; set; } = DateTime.UtcNow;
    public DateTime expectedEndDate { get; set; } = DateTime.UtcNow.AddDays(howManyDays);
    public DateTime? endDate { get; set; } = null;
    public float? penalties { get; set; } = null;
}