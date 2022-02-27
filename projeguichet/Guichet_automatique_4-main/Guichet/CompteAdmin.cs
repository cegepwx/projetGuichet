using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    class CompteAdmin
    {
        private string nom;
        private string nip;

        public string Nom { get => nom; set => nom = value; }
        public string Nip { get => nip; set => nip = value; }

        public CompteAdmin(string nom, string nip)
        {
            this.Nom = nom;
            this.Nip = nip;
        }
    }

}
