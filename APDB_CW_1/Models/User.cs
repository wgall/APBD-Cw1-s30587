using APDB_CW_1.Services;

namespace APDB_CW_1.Models;

public abstract class User(string name, string surname)
{
    public string id { get; set; } = GenerateID.generate(5);
    public string name { get; set; } = name;
    public string surname { get; set; } = surname;
}