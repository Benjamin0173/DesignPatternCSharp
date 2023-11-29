namespace TP.Interface
{
    public class LivreDecorator : IBibliotheque
    {
        private IBibliotheque _bibliotheque;

        void IBibliotheque.AjouterLivre(Livre livre)
        {
            _bibliotheque.AjouterLivre(livre);
        }

        List<Livre> IBibliotheque.ObtenirLivres()
        {
            return _bibliotheque.ObtenirLivres();
        }

        List<Livre> IBibliotheque.RechercherLivres(string titre)
        {
            return _bibliotheque.RechercherLivres(titre);
        }

        void IBibliotheque.SupprimerLivre(Livre livre)
        {
            _bibliotheque.SupprimerLivre(livre);
        }

        public virtual string ObtenirLivres()
        {
            _bibliotheque.ObtenirLivres();
            return null;
        }
    }
}