using Projet_LeagueofLegends.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_LeagueofLegends.Models
{
    public class Equipe
    {
        [Key]
        public int EquipeID { get; set; }
        public string TeamName { get; set; }
        public int Nbrematchgagné { get; set; }

    }
}