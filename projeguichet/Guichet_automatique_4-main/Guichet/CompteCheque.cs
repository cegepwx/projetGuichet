using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{    
    public class CompteCheque : CompteClient
    {
       
        public CompteCheque(string numero, double soldeCompte)
        {
            this.Numerocompte = numero;
            this.Soldecompte = soldeCompte;

        }

    
    }
}
