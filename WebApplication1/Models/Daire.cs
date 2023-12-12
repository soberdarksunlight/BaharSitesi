namespace WebApplication1.Models
{
    public class Daire
    {
        public int Id { get; set; }
        public int DaireNo { get; set; }
        public string Blok { get; set; }
        public int Kat { get; set; }
        public List<EvSahipleri> EvSahipleris { get; set; }

        //public int SorumluKisiId {  get; set; }


    }
}
