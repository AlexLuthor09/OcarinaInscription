using Dapper;
using OcarinaInscription.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcarinaInscription.SQLclass
{
    public class SqlManager
    {
        
        public static List<ChillModel> LoadChild()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ChillModel>("select * from Enfant", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_National,Date_Naissance,Age,Tranche_age,MC,BIM,Fiche_Sante,Remarque,Allergie,Adresse,Prix,Nbr_Jour)" +
                "values (@NOM,@PRENOM,@EMAIL,@N_NATIONAL,@DATE_NAISSANCE,@AGE,@TRANCHE_AGE,@MC,@BIM,@FICHE_SANTE,@REMARQUE,@ALLERGIE,@ADRESSE,@PRIX,@NBR_JOUR)";
               
                cnn.Execute(Query,child);
            }
        }
        public static void UpdateChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"UPDATE Enfant  SET Nom = @NOM,Prenom= @PRENOM,Email= @EMAIL,N_National = @N_NATIONAL,Date_Naissance = @DATE_NAISSANCE,Age = @AGE,Tranche_age= @TRANCHE_AGE,
                   MC =@MC,BIM= @BIM,Fiche_Sante =@FICHE_SANTE,Remarque = @REMARQUE,Allergie=@ALLERGIE,Adresse=@ADRESSE,Prix=@PRIX" +
                 " Where Id = @ID;";

                cnn.Execute(Query, child);
            }
        }
        public static void DeleteChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = "DELETE from Enfant where ID = @ID";

                cnn.Execute(Query, child);
            }
        }
        public static void ChildHavePaid(ChillModel child,DayOfWeek date)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               
                int jour=0;
                bool yesornot = false;
                switch (date)
                {
                    case DayOfWeek.Monday:
                        jour = 1;
                        child.jour1= yesornot = !child.jour1;
                        break;
                    case DayOfWeek.Tuesday:
                        jour = 2;
                        child.jour2 = yesornot = !child.jour2;
                        break;
                    case DayOfWeek.Wednesday:
                        jour = 3;
                        child.jour3 = yesornot = !child.jour3;
                        break;
                    case DayOfWeek.Thursday:
                        jour = 4;
                        child.jour4 = yesornot = !child.jour4;
                        break;
                    case DayOfWeek.Friday:
                        jour = 5;
                        child.jour5 = yesornot = !child.jour5;
                        break;
                }
                
                try 
                { 
                    string Query = $"UPDATE Enfant SET jour{jour} ='{yesornot}' where ID = @ID";
                    cnn.Execute(Query, child);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ChildHavePaid  " + ex.Message);
                }

                
            }
        }
        public static void ExportALLToExcel(string FileName)
        {
            ExcelManager ExcelManager = new ExcelManager();

            string Query = "Select * from Enfant";

            ExcelManager.DataToExcel(DbToDataSet(Query), FileName);

        }
        public static void ExportEnfantToExcel(string FileName)
        {
            ExcelManager ExcelManager = new ExcelManager();  
            
            string Query = "SELECT Nom,Prenom,Tranche_age,Age,Date_Naissance,Email,N_National,Adresse,MC,BIM,Prix,Nbr_jour,jour1,jour2,jour3,jour4,jour5 FROM Enfant";

            ExcelManager.DataToExcel(DbToDataSet(Query), FileName);
        }
        public static void ExportRemarquetToExcel(string FileName)
        {
            ExcelManager ExcelManager = new ExcelManager();

            string Query = "SELECT Nom, Prenom, Remarque, Allergie FROM Enfant where Tranche_age = '";

            ExcelManager.DataToExcel(DbToDataSet(Query + "Bleu'"), FileName + "Bleu");
            ExcelManager.DataToExcel(DbToDataSet(Query + "Vert'"), FileName + "Vert");
            ExcelManager.DataToExcel(DbToDataSet(Query + "Jaune'"), FileName +"Jaune");

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static DataSet DbToDataSet(string Query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                SQLiteCommand sQLiteCommand = new SQLiteCommand(Query, cnn);
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand);
                DataSet dataSet = new DataSet();

                cnn.Open();
                sQLiteDataAdapter.Fill(dataSet);
                cnn.Close();

                return dataSet;
            }
        }
    }
}
