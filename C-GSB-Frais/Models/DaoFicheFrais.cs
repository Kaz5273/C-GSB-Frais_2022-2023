using C_GSB_Frais.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Models
{
    public class DaoFicheFrais
    {
        private Dbal unDbal;

        public DaoFicheFrais(Dbal unDbal)
        {
            this.unDbal = unDbal;
        }

        public void Insert(FicheFrais uneficheFrais)
        {
            string values = "(" + uneficheFrais.Id + ", '" + uneficheFrais.User + "' , '" + uneficheFrais.Etat + "' ," + uneficheFrais.Nb_justificatifs + ", '" + uneficheFrais.Date_modif + "' , '" + uneficheFrais.Montant + "' , '" + uneficheFrais.Mois + "')";
            unDbal.Insert("FicheFrais", values);
        }

        public void Update(FicheFrais uneFicheFrais)
        {
            string values = " user= '" + uneFicheFrais.User + "', " + "etat= " + uneFicheFrais.Etat + "', " + "nb_justificatifs= " + uneFicheFrais.Nb_justificatifs + "', " + "date_modif= " + uneFicheFrais.Date_modif + "', " + "montant= " + uneFicheFrais.Montant + "', " + "mois= '" + uneFicheFrais.Mois + "' ";
            string conditon = "id= " + uneFicheFrais.Id + " ";
            unDbal.Update("FicheFrais", values, conditon);
        }

        public void Delete(FicheFrais uneFicheFrais)
        {
            string value = "id= " + uneFicheFrais.Id;
            unDbal.Delete("FicheFrais", value);
        }
        public List<FicheFrais> SelectAll()
        {
            List<FicheFrais> listFicheFrais = new List<FicheFrais>();
            DataTable myTable = this.unDbal.SelectAll("FicheFrais");

            foreach (DataRow r in myTable.Rows)
            {
                listFicheFrais.Add(new FicheFrais((int)r["id"], (User)r["user"], (Etat)r["etat"], (int)r["nb_justificatifs"], (DateTime)r["date_modif"], (double)r["montant"], (string)r["mois"]));
            }

            return listFicheFrais;
        }

        //public FicheFrais SelectByName(string nameFicheFrais)
        //{

        //}

        public FicheFrais SelectById(int idFicheFrais)
        {
            DataRow result = this.unDbal.SelectById("FicheFrais", idFicheFrais);
            return new FicheFrais((int)result["id"], (User)result["user"], (Etat)result["etat"], (int)result["nb_justificatifs"], (DateTime)result["date_modif"], (double)result["montant"], (string)result["mois"]);

        }


    }
}
