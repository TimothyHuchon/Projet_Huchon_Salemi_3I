﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    abstract class Personne
    {
        private string nom;
        private string prenom;
        private string tel;
        private string id;
        private string motDePasse;

        protected Personne(string nom, string prenom, string tel, string id, string motDePasse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Id = id;
            this.MotDePasse = motDePasse;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Id { get => id; set => id = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   Id == personne.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }

}
