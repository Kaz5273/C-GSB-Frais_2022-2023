using C_GSB_Frais.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Models
{
    public class DaoUser
    {
        private Dbal undbal;

        public DaoUser(Dbal undbal)
        {
            this.undbal = undbal;
        }
        public void Insert (User unUser)
        {
            string values = "(" + unUser.Id + ", '" + unUser.Login + ", '" + unUser.Roles + ", '" + unUser.Password + ", '" + unUser.Nom + ", '" + unUser.Prenom + ", '" + unUser.Adresse + ", '" + unUser.Cp + ", '" + unUser.Date_embauche + ",  '" + unUser.Ville + ", '" + unUser.Old_id+ ")";
            undbal.Insert("User", values);
        }
    }
}
