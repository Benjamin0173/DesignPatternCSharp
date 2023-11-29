namespace TP.Interface
{
    public interface IBibliotheque
    {
        void AjouterLivre(Livre livre);
        void SupprimerLivre(Livre livre);
        List<Livre> RechercherLivres(string titre);
        List<Livre> ObtenirLivres();
    }
}