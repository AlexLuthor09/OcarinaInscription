using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;

namespace OcarinaInscription.Class
{
    class ExcelManager
    {
        public void DataToExcel(string Query,SQLiteConnection cnn, string FileName)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;



            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            string data = String.Empty;
            int i = 0;
            int j = 0;
            try
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(Query, cnn))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for (j = 0; j <= rdr.FieldCount - 1; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(j).ToString();
                                xlWorkSheet.Cells[i + 1, j + 1] = data;
                            }
                            i++;
                        }
                    }
                }
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR : Remplissage");
            }

            try
            {
                //MessageBox.Show("coucou"+truc);
                // xlWorkBook.Save();
                xlWorkBook.SaveAs(FileName + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                // MessageBox.Show("Fichier Sauvegarder !");

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                //MessageBox.Show("Fichier Excel créer , tu peux le trouver ici : " + truc + ".xls");
            }
            catch
            {
                MessageBox.Show("ERROR : Le fichier n'as pas pu se sauvegarder");
            }

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}

