using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    public class Compte
    {
        private int code;
        protected float solde;
        private static int nbComptes;
        public Compte(float s)
        {
            this.code = ++nbComptes;
            this.solde = s;
        }
        public Compte()
        {
            this.code = ++nbComptes; this.solde = 0;
        }
        public void Verser(float mt)
        {
            solde = solde + mt;
        }
        public void Retirer(float mt)
        {
            solde = solde - mt;
        }
        public static int GetNbComptes()
        {
            return nbComptes;
        }
        public override string ToString()
        {
            return (" Code=" + code + " Solde=" + solde);
        }
    }
}
