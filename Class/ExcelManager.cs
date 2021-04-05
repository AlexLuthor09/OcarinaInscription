﻿using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OcarinaInscription.Class
{
    class ExcelManager
    {
        public void DataToExcel(DataSet ds, string FileName)
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
            try
            {
                foreach (DataTable table in ds.Tables)
                {
                    //Add a new worksheet to workbook with the Datatable name
                    Excel.Worksheet excelWorkSheet = xlWorkBook.Sheets.Add();
                    excelWorkSheet.Name = table.TableName;

                    for (int i = 1; i < table.Columns.Count + 1; i++)
                    {
                        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                    }

                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        for (int k = 0; k < table.Columns.Count; k++)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                        }
                    }
                }
                // MessageBox.Show(" Remplissage : Terminer");
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
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : Le fichier n'as pas pu se sauvegarder : "+ ex.ToString());
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

