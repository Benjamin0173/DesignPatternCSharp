using System;
using TP.Interface;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator
            IBibliotheque bibliotheque = new IBibliotheque();
            Console.WriteLine("Bibliotheque :", bibliotheque.ObtenirLivres());
        }
    }
}

// {Bibliothèque bibliothèque = new Bibliothèque();

//             // Ajouter des livres à la bibliothèque
//             bibliothèque.AjouterLivre(new Livre("Harry Potter", "J.K. Rowling", "Roman", "Anglais", true));
//             bibliothèque.AjouterLivre(new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Roman", "Français", true));
//             bibliothèque.AjouterLivre(new Livre("Clean Code", "Robert C. Martin", "Informatique", "Anglais", false));
//             bibliothèque.AjouterLivre(new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", "Roman", "Anglais", true));


//             // Afficher la liste des livres
//             bibliothèque.AfficherListeLivres();
//             do {
//             // Afficher un menu à l'utilisateur
//             // Demander les options disponibles à l'utilisateur
//             Console.WriteLine("\nOptions disponibles :");
//             Console.WriteLine("0. Afficher la liste des livres");
//             Console.WriteLine("1. Ajouter un livre");
//             Console.WriteLine("2. Rechercher des livres");
//             Console.WriteLine("3. Supprimer un livre");
//             Console.WriteLine("4. Quitter");

//             // Lire l'option choisie par l'utilisateur
//             Console.Write("Veuillez choisir une option : ");
//             int option = Convert.ToInt32(Console.ReadLine());

//             // Répondre à l'option choisie par l'utilisateur
//             switch (option)
//             {
//                 case 0:
//                     // Code pour afficher la liste des livres
//                     // Afficher la liste des livres mise à jour
//                     bibliothèque.AfficherListeLivres();
//                     break;
//                 case 1:
//                     // Code pour ajouter un livre
//                     // Ajouter un livre à la bibliothèque
//                     Console.WriteLine("\n\nQuelle Livre Voulez vous ajouter (Titre) ?");
//                     string titre = Console.ReadLine();
//                     Console.WriteLine("\n\nQuelle Auteur Voulez vous ajouter (Auteur) ?");
//                     string auteur = Console.ReadLine();
//                     Console.WriteLine("\n\nQuelle Genre Voulez vous ajouter (Genre) ?");
//                     string genre = Console.ReadLine();
//                     Console.WriteLine("\n\nEn quelle Langue es ce ecrite (Langage) ?");
//                     string langue = Console.ReadLine();
//                     Console.WriteLine("\n\nLe livre est-il physique (1:true 2:false) ?");
//                     bool physique = Convert.ToBoolean(Console.ReadLine());
//                     bibliothèque.AjouterLivre(new Livre(titre, auteur, genre, langue, physique));
//                     break;
//                 case 2:
//                     // Code pour rechercher des livres


//                     Console.WriteLine("\n\nQuelle parametre chercher vous ?");
//                     Console.WriteLine("1. Langue");
//                     Console.WriteLine("2. Genre");
//                     Console.WriteLine("3. Physique/Numérique");
//                     int parametre = Convert.ToInt32(Console.ReadLine());

//                     switch (parametre)
//                         {
//                             case 1:
//                                 Console.WriteLine("\n\nQuelle Langue Voulez vous rechercher ?");
//                                 string langueRecherche = Console.ReadLine();
//                                 bibliothèque.RechercherLivres(langueRecherche, null, null);
//                                 break;
//                             case 2:
//                                 Console.WriteLine("\n\nQuelle Genre Voulez vous rechercher ?");
//                                 string genreRecherche = Console.ReadLine();
//                                 bibliothèque.RechercherLivres(null, null, genreRecherche);
//                                 break;
//                             case 3:
//                                 Console.WriteLine("\n\nLe livre est-il physique ?");
//                                 bool physiqueRecherche = Convert.ToBoolean(Console.ReadLine());
//                                 bibliothèque.RechercherLivres(null, physiqueRecherche, null);
//                                 break;
//                             default:
//                                 Console.WriteLine("\nOption invalide. Veuillez choisir une option valide.");
//                                 break;

//                         }
//                     break;
//                 case 3:
//                     // Code pour supprimer un livre
//                     // Supprimer un livre de la bibliothèque
//                     bibliothèque.AfficherListeLivres();
//                     Console.WriteLine("\n\nQuelle Livre Voulez vous supprimer (Titre) ?");
//                     string livre = Console.ReadLine();
//                     bibliothèque.SupprimerLivre(livre);       
//                     break;
//                 case 4:
//                     // Quitter le programme
//                     Console.WriteLine("\nMerci d'avoir utilisé notre bibliothèque. Au revoir !");
                    
//                     break;
//                 default:
//                     Console.WriteLine("\nOption invalide. Veuillez choisir une option valide.");
//                     break;
//             }
        
//         }while(true);}