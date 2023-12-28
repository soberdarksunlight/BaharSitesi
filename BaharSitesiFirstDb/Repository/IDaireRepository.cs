namespace BaharSitesiFirstDb.Repository
{
    public interface IDaireRepository
    {
        IEnumerable<Daire> GetDaires();

        IEnumerable<Daire> GetId();
        IEnumerable<Daire> GetDaireNo();
        IEnumerable<Daire> GetBlok();
        IEnumerable<Daire> GetKat();
    }
}
