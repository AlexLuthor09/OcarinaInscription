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
        public bool Lundi{ get; set; }
        public bool Mardi { get; set; }
        public bool Mercredi { get; set; }
        public bool Jeudi { get; set; }
        public bool Vendredi { get; set; }
        public int PlaineId { get; set; }
    }
}
