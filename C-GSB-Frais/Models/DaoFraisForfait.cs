using C_GSB_Frais.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GSB_Frais.Models
{
    public class DaoFraisForfait
    {
        private Dbal unDbal;

        public DaoFraisForfait(Dbal unDbal)
        {
            this.unDbal = unDbal;
        }

        public void Insert(FraisForfait unFraisForfait)
        {
            string values = "(" + unFraisForfait.Id + ", '" + unFraisForfait.Montant + "' ,'" + unFraisForfait.Libelle + "')";
            unDbal.Insert("fraisForfait", values);
        }

        public void Update(FraisForfait unFraisForfait)
        {
            string values = "montant= '" + unFraisForfait.Montant + "' ," + "libelle= '" + unFraisForfait.Libelle + "' ";
            string condition = "id= " + unFraisForfait.Id + " ";
            unDbal.Update("fraiForfait", values, condition);
        }

        public void Delete(FraisForfait unFraisForfait)
        {
            string values = "id= " + unFraisForfait.Id;
            unDbal.Delete("FraisForfait", values);
        }

        public List<FraisForfait> SelectAll()
        {
            List<FraisForfait> listFraisForfait = new List<FraisForfait>();
            DataTable myTable = this.unDbal.SelectAll("fraisForfait");

            foreach (DataRow r in myTable.Rows)
            {
                listFraisForfait.Add(new FraisForfait((int)r["id"], (double)r["montant"], (string)r["libelle"]));
            }

            return listFraisForfait;
        }

        //public FraisForfait SelectByName(string nameFraisForfait) { }

        public FraisForfait SelectById(int idFraisForfait)
        {
            DataRow result = this.unDbal.SelectById("fraisForfait", idFraisForfait);
            return new FraisForfait((int)result["id"], (double)result["montant"], (string)result["libelle"]);

        }

    }
}
