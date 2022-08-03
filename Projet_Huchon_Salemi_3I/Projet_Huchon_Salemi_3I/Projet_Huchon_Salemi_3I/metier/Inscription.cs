using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Inscription
    {
        private bool passager;
        private bool velo;
        private Balade balade;
        private Membre membre;
        private Velo veloDetails;

        public Inscription(bool passager, bool velo)
        {
            this.Passager = passager;
            this.Velo = velo;
        }

        public bool Passager { get => passager; set => passager = value; }
        public bool Velo { get => velo; set => velo = value; }
        internal Balade Balade { get => balade; set => balade = value; }
        internal Membre Membre { get => membre; set => membre = value; }
        internal Velo VeloDetails { get => veloDetails; set => veloDetails = value; }

        public override bool Equals(object obj)
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
