using System;

public class ScooterEssence : Scooter
{
  public ScooterEssence(string modele, string couleur,
    int puissance) : base(modele, couleur, puissance){}

  public override void afficheCaracteristiques()
  {
    Console.WriteLine("Scooter à essence de modèle : " +
      modele + " de couleur : " + couleur + 
      " de puissance : " + puissance);
  }

}