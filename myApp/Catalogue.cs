using System;

public class Catalogue
{
  public static int nbAutos = 3;
  public static int nbScooters = 2;

  static void Main(string[] args)
  {
    FabriqueVehicule fabrique;
    Automobile[] autos = new Automobile[nbAutos];
    Scooter[] scooters = new Scooter[nbScooters];
    Console.WriteLine("Voulez-vous utiliser " +
      "des véhicules électriques (1) ou à essence (2) :");
    string choix = Console.ReadLine();
    if (choix == "1")
    {
      fabrique = new FabriqueVehiculeElectricite();
    }
    else
    {
      fabrique = new FabriqueVehiculeEssence();
    }
    for (int index = 0; index < nbAutos; index++)
      autos[index] = fabrique.creeAutomobile("standard", 
        "jaune", 6+index, 3.2);
    for (int index = 0; index < nbScooters; index++)
      scooters[index] = fabrique.creeScooter("classic", 
        "rouge", 2+index);
    foreach (Automobile auto in autos)
      auto.afficheCaracteristiques();
    foreach (Scooter scooter in scooters)
      scooter.afficheCaracteristiques();
  }

}