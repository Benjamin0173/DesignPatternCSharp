using System

namespace Builder.Interfaces
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected List<string> documents;

        public abstract void construitBonDeCommande(string
          nomClient);

        public abstract void construitDemandeImmatriculation
          (string nomDemandeur);

        public abstract Liasse resultat();
    }
}