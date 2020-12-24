using Projet_LeagueofLegends.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_LeagueofLegends.Models
{
    public class Joueur
    {
        [Key]
        public int JoueurID { get; set; }
        public String NameJoueur { get; set; }
        [ForeignKey ("Equipes")]
        public int EquipeID { get; set; }
        public virtual Equipe Equipes { get; set; }
    }
}