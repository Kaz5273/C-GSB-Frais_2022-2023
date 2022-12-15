using C_GSB_Frais.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace C_GSB_Frais.Models
{
    public class DaoEtat
    {
        private Dbal unDbal;

        public DaoEtat(Dbal unDbal) 
        {
            this.unDbal = unDbal;
        }

        public void Insert(Etat unEtat)
        {
            string values ="(" + unEtat.Id + ", '" + unEtat.Libelle + "')";
            unDbal.Insert("Etat", values);
        }

        public void Update(Etat unEtat)
        {
            string values = " libelle= '" + unEtat.Libelle + "' ";
            string condition = "id= " + unEtat.Id + " ";
            unDbal.Update("Etat", values, condition);
        }

        public void Delete(Etat unEtat)
        {
            string values = "id= " + unEtat.Id;
            unDbal.Delete("Etat", values);
        }

        public List<Etat> SelectAll() 
        {
            List<Etat> listEtat= new List<Etat>();
            DataTable myTable = this.unDbal.SelectAll("Etat");

            foreach (DataRow r in myTable.Rows)
            {
                listEtat.Add(new Etat((int)r["id"], (string)r["libelle"]);
            }
            return listEtat;
        }

        //public Etat SelectedByName(string libelleEtat)
        //{

        //}

        public Etat SelectedById(int idEtat)
        {
            DataRow result = this.unDbal.SelectById("Etat", idEtat);
            return new Etat((int)result["id"], (string)result["libelle"]);
        }

    }
}
