using System;
using System.Collections.Generic;
using Projet_LeagueofLegends.Models;

namespace Projet_LeagueofLegends.DAL
{
    public class LeagueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LeagueContext>
    {
        protected override void Seed(LeagueContext context)
        {
            var equipes = new List<Equipe>
            {
                new Equipe{EquipeID=1,TeamName="G2 Esports",Nbrematchgagné=13},
                new Equipe{EquipeID=2,TeamName="Fnatic",Nbrematchgagné=12},
                new Equipe{EquipeID=3,TeamName="Rogue",Nbrematchgagné=10},
                new Equipe{EquipeID=4,TeamName="Mad Lions",Nbrematchgagné=9},
                new Equipe{EquipeID=5,TeamName="SK Gaming",Nbrematchgagné=9},
                new Equipe{EquipeID=6,TeamName="FC Schalke 04",Nbrematchgagné=8},
                new Equipe{EquipeID=7,TeamName="Excel Esports",Nbrematchgagné=8},
                new Equipe{EquipeID=8,TeamName="Misfits Gaming",Nbrematchgagné=7},
                new Equipe{EquipeID=9,TeamName="Team Vitality",Nbrematchgagné=7},
                new Equipe{EquipeID=10,TeamName="Origen",Nbrematchgagné=6},
            };
            equipes.ForEach(e => context.Equipes.Add(e));
            context.SaveChanges();
            var resultats = new List<Resultat>
            {
            new Resultat{ResultatID=1,IDEquipe1=4,IDEquipe2=1,victoire=2},
            new Resultat{ResultatID=2,IDEquipe1=9,IDEquipe2=6,victoire=1},
            new Resultat{ResultatID=3,IDEquipe1=10,IDEquipe2=5,victoire=2},
            new Resultat{ResultatID=4,IDEquipe1=3,IDEquipe2=7,victoire=1},
            new Resultat{ResultatID=5,IDEquipe1=8,IDEquipe2=2,victoire=2},
            };
            resultats.ForEach(r => context.Resultats.Add(r));
            context.SaveChanges();

            var joueurs = new List<Joueur>
            {
                new Joueur{JoueurID=1, NameJoueur="Wunder" ,EquipeID=1},
                new Joueur{JoueurID=2, NameJoueur="Jankos" ,EquipeID=1},
                new Joueur{JoueurID=3, NameJoueur="Caps" ,EquipeID=1},
                new Joueur{JoueurID=4, NameJoueur="Perkz" ,EquipeID=1},
                new Joueur{JoueurID=5, NameJoueur="Mikyx" ,EquipeID=1},

                new Joueur{JoueurID=6, NameJoueur="Bwipo" ,EquipeID=2},
                new Joueur{JoueurID=7, NameJoueur="Selfmade" ,EquipeID=2},
                new Joueur{JoueurID=8, NameJoueur="Nemesis" ,EquipeID=2},
                new Joueur{JoueurID=9, NameJoueur="Rekkles" ,EquipeID=2},
                new Joueur{JoueurID=10, NameJoueur="Huylissang" ,EquipeID=2},

                new Joueur{JoueurID=11, NameJoueur="Finn" ,EquipeID=3},
                new Joueur{JoueurID=12, NameJoueur="Inspired" ,EquipeID=3},
                new Joueur{JoueurID=13, NameJoueur="Larssen" ,EquipeID=3},
                new Joueur{JoueurID=14, NameJoueur="Hans Sama" ,EquipeID=3},
                new Joueur{JoueurID=15, NameJoueur="Vander" ,EquipeID=3},

                new Joueur{JoueurID=16, NameJoueur="Orome" ,EquipeID=4},
                new Joueur{JoueurID=17, NameJoueur="Shadow" ,EquipeID=4},
                new Joueur{JoueurID=18, NameJoueur="Humanoid" ,EquipeID=4},
                new Joueur{JoueurID=19, NameJoueur="Carzzy" ,EquipeID=4},
                new Joueur{JoueurID=20, NameJoueur="Kaiser" ,EquipeID=4},

                new Joueur{JoueurID=21, NameJoueur="Jenax" ,EquipeID=5},
                new Joueur{JoueurID=22, NameJoueur="Trick" ,EquipeID=5},
                new Joueur{JoueurID=23, NameJoueur="Zazee" ,EquipeID=5},
                new Joueur{JoueurID=24, NameJoueur="Crownshot" ,EquipeID=5},
                new Joueur{JoueurID=25, NameJoueur="Jesiz" ,EquipeID=5},

                new Joueur{JoueurID=26, NameJoueur="Odoamne" ,EquipeID=6},
                new Joueur{JoueurID=27, NameJoueur="Lurox" ,EquipeID=6},
                new Joueur{JoueurID=28, NameJoueur="Abbedagge" ,EquipeID=6},
                new Joueur{JoueurID=29, NameJoueur="Innaxe" ,EquipeID=6},
                new Joueur{JoueurID=30, NameJoueur="Nukes" ,EquipeID=6},

                new Joueur{JoueurID=31, NameJoueur="Kryze" ,EquipeID=7},
                new Joueur{JoueurID=32, NameJoueur="Caedrel" ,EquipeID=7},
                new Joueur{JoueurID=33, NameJoueur="Special" ,EquipeID=7},
                new Joueur{JoueurID=34, NameJoueur="Patrik" ,EquipeID=7},
                new Joueur{JoueurID=35, NameJoueur="Tore" ,EquipeID=7},

                new Joueur{JoueurID=36, NameJoueur="Dan Dan" ,EquipeID=8},
                new Joueur{JoueurID=37, NameJoueur="Razork" ,EquipeID=8},
                new Joueur{JoueurID=38, NameJoueur="Febiven" ,EquipeID=8},
                new Joueur{JoueurID=39, NameJoueur="Kobbe" ,EquipeID=8},
                new Joueur{JoueurID=40, NameJoueur="Doss" ,EquipeID=8},

                new Joueur{JoueurID=41, NameJoueur="Cabochard" ,EquipeID=9},
                new Joueur{JoueurID=42, NameJoueur="Nji" ,EquipeID=9},
                new Joueur{JoueurID=43, NameJoueur="Milica" ,EquipeID=9},
                new Joueur{JoueurID=44, NameJoueur="Comp" ,EquipeID=9},
                new Joueur{JoueurID=45, NameJoueur="Labrov" ,EquipeID=9},

                new Joueur{JoueurID=46, NameJoueur="Alphari" ,EquipeID=10},
                new Joueur{JoueurID=47, NameJoueur="Xerxe" ,EquipeID=10},
                new Joueur{JoueurID=48, NameJoueur="Nukeduck" ,EquipeID=10},
                new Joueur{JoueurID=49, NameJoueur="Upset" ,EquipeID=10},
                new Joueur{JoueurID=50, NameJoueur="Destiny" ,EquipeID=10}
            };
            joueurs.ForEach(j => context.Joueurs.Add(j));
            context.SaveChanges();
        }

    }
}