    using System;

    class Livre : Bibliothèque
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Genre { get; set; }
        public string Langue { get; set; }
        public bool Physique { get; set; }

        public Livre(string titre, string auteur, string genre, string langue, bool physique)
        {
            Titre = titre;
            Auteur = auteur;
            Genre = genre;
            Langue = langue;
            Physique = physique;
        }
    }