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
       
        public static List<ChillModel> LoadChild(int IDplaines)
        {
            if(IDplaines == null)
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<ChillModel>("select * From Enfant", new DynamicParameters());
                    return output.ToList();
                } 
            }
            else
            { 
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                var output = cnn.Query<ChillModel>($"select * From Enfant where PlaineID = {IDplaines}", new DynamicParameters());
                return output.ToList();
                
                }
            }

            
        }
        public static List<PlaineModel> LoadPlaines()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PlaineModel>("select * From Plaine", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_National,Date_Naissance,Age,Tranche_age,MC,BIM,Fiche_Sante,Remarque,Allergie,Adresse,Prix,Nbr_Jour,PlaineID)" +
                "values (@NOM,@PRENOM,@EMAIL,@N_NATIONAL,@DATE_NAISSANCE,@AGE,@TRANCHE_AGE,@MC,@BIM,@FICHE_SANTE,@REMARQUE,@ALLERGIE,@ADRESSE,@PRIX,@NBR_JOUR,@PlaineID)";
               
                cnn.Execute(Query,child);
            }
        }
        public static void UpdateChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"UPDATE Enfant  SET Nom = @NOM,Prenom= @PRENOM,Email= @EMAIL,N_National = @N_NATIONAL,Date_Naissance = @DATE_NAISSANCE,Age = @AGE,Tranche_age= @TRANCHE_AGE,
                   MC =@MC,BIM= @BIM,Fiche_Sante =@FICHE_SANTE,Remarque = @REMARQUE,Allergie=@ALLERGIE,Adresse=@ADRESSE,Prix=@PRIX,PlaineID=@PlaineID" +
                 " Where Id = @ID;";

                cnn.Execute(Query, child);
            }
        }


        public static void UpdatePlaine(PlaineModel plaineModel)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"UPDATE Plaine  SET Nom = @NOM, DateDebut=@DATEDEBUT, DateFin=@DATEFIN" +
                 " Where Id = @ID;";

                cnn.Execute(Query, plaineModel);
            }
        }

        public static void SavePlaine(PlaineModel plaineModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"INSERT INTO Plaine  (Nom,DateDebut,DateFin)" +
                "values (@NOM,@DATEDEBUT,@DATEFIN)";

                cnn.Execute(Query, plaineModel);
            }
        }
        internal static void DeletePlaine(PlaineModel plaine)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query1 = $"DELETE from Enfant where PlaineID = {plaine.Id}";
                string Query2 = $"DELETE from Plaine where ID = {plaine.Id}";
                cnn.Execute(Query1);
                cnn.Execute(Query2);
            }
        }
        public static void DeleteChild(ChillModel child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = $"DELETE from Enfant where ID = {child.Id}";

                cnn.Execute(Query, child);
            }
        }
        public static void NewWeek(PlaineModel plaineModel)
        {
            
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string Query = @"Insert into Plaine (Nom,DateDebut,DateFin) values (@NOM,@DATEDEBUT,@DATEFIN)";

                cnn.Execute(Query,plaineModel);
            }
        }
        public static void ChildHavePaid(ChillModel child,DayOfWeek date)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               
                
                string Query="";
                int o = child.Nbr_jour;
                
                switch (date)
                {
                    case DayOfWeek.Monday:
                        if (child.Lundi=!child.Lundi)
                            child.Nbr_jour =  o + 1;
                        else
                            child.Nbr_jour = o - 1;
                         Query = @"UPDATE Enfant SET Lundi = @LUNDI, Nbr_Jour = @Nbr_jour where ID = @ID";
                        break;
                    case DayOfWeek.Tuesday:
                        if (child.Mardi=!child.Mardi)
                            child.Nbr_jour = o + 1;
                        else
                            child.Nbr_jour = o - 1;
                        Query =@"UPDATE Enfant SET Mardi =@MARDI,  Nbr_Jour = @Nbr_jour where ID = @ID";
                        break;
                    case DayOfWeek.Wednesday:
                        if (child.Mercredi=!child.Mercredi)
                            child.Nbr_jour = o + 1;
                        else
                            child.Nbr_jour = o - 1;
                        Query = @"UPDATE Enfant SET Mercredi =@MERCREDI, Nbr_Jour = @Nbr_jour where ID = @ID";
                        break;
                    case DayOfWeek.Thursday:
                        if (child.Jeudi = !child.Jeudi)
                            child.Nbr_jour = o + 1;
                        else
                            child.Nbr_jour = o - 1;
                        Query = @"UPDATE Enfant SET Jeudi =@JEUDI, Nbr_Jour = @Nbr_jour where ID = @ID";
                        break;
                    case DayOfWeek.Friday:
                        if (child.Vendredi = !child.Vendredi)
                            child.Nbr_jour = o + 1;
                        else
                            child.Nbr_jour = o - 1;
                        Query = @"UPDATE Enfant SET Vendredi =@VENDREDI, Nbr_Jour = @Nbr_jour where ID = @ID";
                        break;
                    default:
                        Query = null;
                        break;
                      
                }
                
                try 
                { 

                    cnn.Execute(Query, child);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ChildHavePaid  " + ex.Message);
                }

                
            }
        }
        public static void ExportALLToExcel(string FileName,int plaine)
        {
            ExcelManager ExcelManager = new ExcelManager();

            string Query = $"Select * from Enfant Where PlaineID ={plaine}";

            ExcelManager.DataToExcel(DbToDataSet(Query), FileName);

        }
        public static void ExportEnfantToExcel(string FileName,int plaine)
        {
            ExcelManager ExcelManager = new ExcelManager();  
            
            string Query = $"SELECT Nom,Prenom,Tranche_age,Age,Date_Naissance,Email,N_National,Adresse,Fiche_Sante,MC,BIM,Prix,Nbr_jour,Lundi,Mardi,Mercredi,Jeudi,Vendredi FROM Enfant Where PlaineID ={plaine} ";

            ExcelManager.DataToExcel(DbToDataSet(Query), FileName);
        }
        public static void ExportRemarquetToExcel(string FileName,int plaine)
        {
            ExcelManager ExcelManager = new ExcelManager();

            string Query = $"SELECT Nom, Prenom, Remarque, Allergie FROM Enfant where Tranche_age = Where PlaineID ={plaine}";

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
