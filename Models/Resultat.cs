using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_LeagueofLegends.Models
{
    public class Resultat
    {
        [Key]
        public int ResultatID { get; set; }

        [ForeignKey("equipe1"),Column(Order =0)]
        public int? IDEquipe1 { get; set ;}
        public virtual Equipe equipe1 { get; set; }

        [ForeignKey("equipe2"),Column(Order =1)]
        public int? IDEquipe2 { get; set; }
        public virtual Equipe equipe2 { get; set; }

        public int victoire { get; set; }

    }
}