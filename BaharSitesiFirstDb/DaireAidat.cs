using System;
using System.Collections.Generic;

namespace BaharSitesiFirstDb;

public partial class DaireAidat
{
    public int Id { get; set; }

    public string Dönem { get; set; } = null!;

    public DateTime SonÖdemeTarihi { get; set; }

    public DateTime ÖdemeTarihi { get; set; }

    public int ÖdenenTutar { get; set; }
}
