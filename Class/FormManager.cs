using OcarinaInscription.Forms;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcarinaInscription.Class
{
    class FormManager
    {

        public void OpenInscription(int id)
        {
            Inscription Inscription = new Inscription(id);
            OpenForms(Inscription);
        }
        public void OpenInscription(ChillModel chillmodel)
        {
            Inscription Inscription = new Inscription(chillmodel);
            OpenForms(Inscription);
        }
        public void OpenExcelExport(char quoi,int p)
        {
            ExcelExport excel=new ExcelExport(quoi,p);
            OpenForms(excel);
        }
        public void OpenNewWeek()
        {
            Newweek newweek = new Newweek();
            OpenForms(newweek);
        }
        public void OpenWeekChoise(MainForm mainForm)
        {
            WeekChoise weekChoise = new WeekChoise(mainForm);
            
            OpenForms(weekChoise);
            
        }
        public void OpenNewWeek(PlaineModel plaine)
        {
            Newweek newweek = new Newweek(plaine);
            OpenForms(newweek);
        }
        public void OpenForms(Form activeform)
        {
            activeform.Activate();
            activeform.Visible = true;
          
        }
    }
}
