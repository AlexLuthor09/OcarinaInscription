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

        public void OpenInscription(PlaineModel plaine)
        {
            Inscription Inscription = new Inscription(plaine);
            OpenForms(Inscription);
        }
        public void OpenInscription(ChillModel chillmodel, PlaineModel plaine)
        {
            Inscription Inscription = new Inscription(chillmodel, plaine);
            OpenForms(Inscription);
        }
        public void OpenExcelExport(char quoi)
        {
            ExcelExport excel=new ExcelExport(quoi);
            OpenForms(excel);
        }
        public void OpenNewWeek()
        {
            Newweek newweek = new Newweek();
            OpenForms(newweek);
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
