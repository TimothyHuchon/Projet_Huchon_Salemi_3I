using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Tresorier : Personne
    {
        public Tresorier(string nom, string prenom, string tel, string id, string motDePasse)
            : base(nom, prenom, tel, id, motDePasse)
        {
        }


        public override string ToString()
        {
            return "Tresorier { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " }";

        }


    }
}
