using System;
using System.Collections.Generic;

namespace BaharSitesiFirstDb;

public partial class Daire
{
    public int Id { get; set; }

    public int DaireNo { get; set; }

    public string Blok { get; set; } = null!;

    public int Kat { get; set; }
}
