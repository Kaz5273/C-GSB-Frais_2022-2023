using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Business
{
    public class Etat
    {
        private int id;
        private string libelle;

        public Etat(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
