public class TestVendeur
{
  static void Main(string[] args)
  {
    // initialisation du vendeur du syst�me
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.nom = "Vendeur Auto";
    leVendeur.adresse = "Paris";
    leVendeur.email = "vendeur@vendeur.com";
    // affichage du vendeur du syst�me
    affiche();
  }

  public static void affiche()
  {
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.affiche();
  }
}
