using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Responsable : Personne
    {
        public Categorie categorie;
        public Responsable(string nom, string prenom, string tel, string id, string motDePasse)
            : base(nom, prenom, tel, id, motDePasse)
        {

        }

        public override string ToString()
        {
            return "Responsable { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " }";
        }
    }
}
