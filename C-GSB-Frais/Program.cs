using C_GSB_Frais.Business;
using C_GSB_Frais.Models;

namespace C_GSB_Frais
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            //Dao Etat ok
            //Dao User ok
            //Dao Fichefrais 
            //Dao FraisForfait
            //Dao LigneFraisForfait
            //Dao LigneFraisHorsForfait 

            Dbal dbal = new Dbal();
            DaoUser daoUser = new DaoUser(dbal);
            DaoEtat daoEtat = new DaoEtat(dbal);
            DaoFraisForfait daoFraisForfait = new DaoFraisForfait(dbal);

            User unUser = new User(1, "test", "g,slG", "blabla", "kaz", "52 route", "73390", new DateTime(2022, 12, 15), "chateauneuf", "a131");
            Etat unEtat = new Etat(1, "Saisie clôturée");
            DaoFicheFrais daoFicheFrais = new DaoFicheFrais(dbal, daoUser, daoEtat);
            DateTime newDate = new DateTime(2022, 12, 15);
            FicheFrais uneficheFrais = new FicheFrais(218, unUser, unEtat, 32, newDate, 1000.53m, "202201");
            daoFicheFrais.SelectAll();

            //daoUser.SelectAll();
            //Etat unEtat = new Etat(5, "test");
            //daoEtat.Delete(unEtat);






        }
    }
}