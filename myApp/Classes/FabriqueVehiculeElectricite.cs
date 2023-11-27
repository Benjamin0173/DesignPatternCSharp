using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Classes
{
    internal class FabriqueVehiculeElectricite : FabriqueVehicule
    {
        public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new Automobile(modele, couleur, puissance, espace);
        }

        public Scooter creerScooter(string modele, string couleur, int puissance, double espace)
        {
            return new Scooter(modele, couleur, puissance, espace);
        }
    }
}
