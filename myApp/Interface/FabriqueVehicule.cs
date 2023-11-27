using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myApp.Classes;

namespace myApp.Interface
{
    internal interface FabriqueVehicule
    {
        Automobile creeAutomobile(string modele, string couleur, int puissance, double espace);
        Scooter creeScooter(string modele, string couleur, int puissance);     
    }
}