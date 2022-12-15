using C_GSB_Frais.Business;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Models
{
    public class DaoUser
    {
        private Dbal unDbal;

        public DaoUser(Dbal undbal)
        {
            this.unDbal = undbal;
        }
        public void Insert(User unUser)
        {
            string values = "(" + unUser.Id + ", '" + unUser.Login + "', '" + unUser.Roles + "', '" + unUser.Password + "', '" + unUser.Nom + "', '" + unUser.Prenom + "', '" + unUser.Adresse + "', '" + unUser.Cp + "', '" + unUser.Date_embauche + ",  '" + unUser.Ville + "', '" + unUser.Old_id + "')";
            unDbal.Insert("User", values);
        }
        public void Update(User unUser)
        {
            string values = " login= '" + unUser.Login + "', " + "role= '" + unUser.Roles + "', " + "password= '" + unUser.Password + "', " + "nom= '" + unUser.Nom + "', " + "prenom= '" + unUser.Prenom + "', " + "adresse= '" + unUser.Adresse + "', " + "cp= " + unUser.Cp + ", " + "date_embauche= '" + unUser.Date_embauche.ToString("yyyy-MM-dd") + "', " + "ville= '" + unUser.Ville + "', " + "old_id= '" + unUser.Old_id + "'";
            string condition = " id= " + unUser.Id + " ";
            unDbal.Update("User", values, condition);
        }

        public void Delete(User unUser)
        {
            string values = "id= " + unUser.Id;
            unDbal.Delete("User", values);
        }
        
        public List<User> SelectAll()
        {
            List<User> listUser = new List<User>();
            DataTable myTable = this.unDbal.SelectAll("User");
            foreach (DataRow r in myTable.Rows) 
            {
                listUser.Add(new User((int)r["id"], (string)r["login"], (string)r["role"], (string)r["password"], (string)r["nom"], (string)r["prenom"], (string)r["adresse"], (string)r["cp"], (DateTime)r["date_embauche"], (string)r["ville"], (string)r["old_id"]));
            }
            return listUser;
        }

        //public User SelectByName(string nameUser)
        //{
        //    DataTable result = new DataTable();
        //    result = this.unDbal.SelectByField
        //}

        public User SelectById(int idUser)
        {
            DataRow result = this.unDbal.SelectById("User", idUser);
            return new User((int)result["id"], (string)result["login"], (string)result["role"], (string)result["pasword"], (string)result["nom"], (string)result["prenom"], (string)result["adresse"], (string)result["cp"], (DateTime)result["date_embauche"], (string)result["vile"], (string)result["old_id"]);
        }
    }

}
