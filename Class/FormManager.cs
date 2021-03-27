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
       
        
        public void OpenInscription()
        {
            Inscription Inscription = new Inscription();
            OpenForms(Inscription);
        }
        public void OpenInscription(ChillModel chillmodel)
        {
            Inscription Inscription = new Inscription(chillmodel);
            OpenForms(Inscription);
        }
        public void OpenForms(Form activeform)
        {
            activeform.Activate();
            activeform.Visible = true;
        }
    }
}
