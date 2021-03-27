using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcarinaInscription.Class
{
    public class ChillModel
    {
        public int Id  { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string N_National { get; set; }
        public string Date_Naissance { get; set; }
        public int Age{ get; set; }
        public string Prix { get; set; }
        public string Tranche_age{ get; set; }
        public bool MC { get; set; }
        public bool BIM { get; set; }
        public bool Fiche_sante { get; set; }
        public int Nbr_jour { get; set; }
        public string Remarque{ get; set; }
        public string Allergie{ get; set; }
        public string Adresse { get; set; }
        public bool jour1{ get; set; }
        public bool jour2 { get; set; }
        public bool jour3 { get; set; }
        public bool jour4 { get; set; }
        public bool jour5 { get; set; }

        public string FullName
        {
            get
            {
                return $"{Nom} {Prenom}";
            }
        }

    }
}
