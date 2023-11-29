using System;

class Bibliothèque
    {
        private List<Livre> livres;

        public Bibliothèque()
        {
            livres = new List<Livre>();
        }

        public void AjouterLivre(Livre livre)
        {
            livres.Add(livre);
            return;
        }

        public void SupprimerLivre(string titre)
        {
            Livre livre = livres.Find(l => l.Titre == titre);
            if (livre != null)
            {
                livres.Remove(livre);
            }
            return;
        }

        public List<Livre> RechercherLivres(string langue = null, bool? physique = null, string genre = null)
        {
            if (langue == null && physique == null && genre == null)
            {
                return livres;
            }

            return Console.WriteLine(livres.FindAll(l =>
                (langue == null || l.Langue == langue) &&
                (physique == null || l.Physique == physique) &&
                (genre == null || l.Genre == genre)
            ));
        }

        public void AfficherListeLivres()
        {
            Console.WriteLine("\nListe des livres :");
            foreach (Livre livre in livres)
            {
                Console.WriteLine($"Titre : {livre.Titre}, Auteur : {livre.Auteur}, Genre : {livre.Genre}, Langue : {livre.Langue}, Physique : {livre.Physique}");
            }
            return;
        }
    }