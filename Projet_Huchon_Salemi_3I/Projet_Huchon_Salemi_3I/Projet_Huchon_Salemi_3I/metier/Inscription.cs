using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Inscription
    {
        private Decimal id_inscription;
        private Boolean passager;
        private Boolean velo;
        private Decimal id_personne;
        private Decimal num_balade;
        private Decimal id_velo;

        public Inscription()
        {
        }

        public Inscription(decimal id_inscription)
        {
            this.id_inscription = id_inscription;
        }

        public Inscription(Boolean passager, Boolean velo)
        {
            this.Passager = passager;
            this.Velo = velo;
        }

        public Inscription(decimal id_inscription, bool passager, bool velo)
        {
            this.Id_inscription = id_inscription;
            this.Passager = passager;
            this.Velo = velo;
        }



        public Decimal Id_inscription { get => id_inscription; set => id_inscription = value; }
        public Boolean Passager { get => passager; set => passager = value; }
        public Boolean Velo { get => velo; set => velo = value; }
        public decimal Id_personne { get => id_personne; set => id_personne = value; }
        public decimal Num_balade { get => num_balade; set => num_balade = value; }
        public decimal Id_velo { get => id_velo; set => id_velo = value; }

        public override Boolean Equals(object obj)
        {
            return obj is Inscription inscription &&
                   Passager == inscription.Passager &&
                   Velo == inscription.Velo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Passager, Velo);
        }

        public override string ToString()
        {
            return "Inscription{" +
                " Passager: " + Passager +
                " Velo: " + Velo +
                "}";
        }
    }
}
