﻿//Consegna: Milestone 0:
//Modelliamo un’entità Player che rappresenta un giocatore di basket

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Entity_Framework_Players
{
    [Table("Player")]
    [Index(nameof(Surname), IsUnique = true)]
    public class Players
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Rating { get; set; }
        public int PlayedGames { get; set; }
        public int GamesWon { get; set; }

    }
}