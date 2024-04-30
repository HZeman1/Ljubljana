using System;
using System.Collections.Generic;

namespace REST;

public partial class Vozilo
{
    public int Id { get; set; }

    public string? KratkoImeVozila { get; set; }

    public string? NamembnostVozila { get; set; }

    public string? ZnamkaVozila { get; set; }

    public string? Registracija { get; set; }

    public int? StevilkaSledilneNaprave { get; set; }

    public string? Oprema { get; set; }
}
