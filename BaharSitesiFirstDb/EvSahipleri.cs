using System;
using System.Collections.Generic;

namespace BaharSitesiFirstDb;

public partial class EvSahipleri
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public string TelefonNo { get; set; } = null!;

    public string Eposta { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
