using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcarinaInscription.Class
{
    public class PlaineModel
    {
        public int Id { get; set; }
        public string DateDebut { get; set; }
        public string DateFin{ get; set; }
        public string Nom { get; set; }
        

        public string fullname
        {
            get
            {
                return $"{Nom}-{DateDebut}-{DateFin}";
            }
        }
    }
}
