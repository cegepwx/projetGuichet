using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    class Fournisseur
    {
        private string nomFacture;
        private string numberFacture;
        private double montantFacture;

        public string NomFacture { get => nomFacture; set => nomFacture = value; }
        public string NumberFacture { get => numberFacture; set => numberFacture = value; }
        public double MontantFacture { get => montantFacture; set => montantFacture = value; }

        public Fournisseur()
        {
            this.NomFacture = nomFacture;
            this.NumberFacture = numberFacture;
            this.MontantFacture = montantFacture;
        }
    }
}
