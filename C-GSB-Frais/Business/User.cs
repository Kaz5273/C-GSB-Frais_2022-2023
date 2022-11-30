using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Business
{
    public class User
    {
        private int id;
        private string login;
        private string password;
        private string nom;
        private string prenom;
        private string adresse;
        private string cp;
        private DateTime date_embauche;
        private string ville;
        private string old_id;

        public User(int id, string login, string password, string nom, string prenom, string adresse, string cp, DateTime date_embauche, string ville, string old_id ) 
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.date_embauche = date_embauche;
            this.ville = ville; 
            this.old_id = old_id;
        }

    }
}
