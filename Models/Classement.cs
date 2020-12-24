using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet_LeagueofLegends.Models
{
    public class Classement
    {
        [Key]
        public int ClassementID { get; set; }
        [ForeignKey("equipe")]
        public int IDEquipe { get; set; }
        public virtual Equipe equipe { get; set; }
    }
}