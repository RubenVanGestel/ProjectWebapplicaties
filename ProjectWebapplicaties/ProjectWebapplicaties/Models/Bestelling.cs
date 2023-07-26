using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Bestelling
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public bool IsBezorging { get; set; }

        //navigatieproperties

        public Klant Klant { get; set; }
        public Medewerker Medewerker { get; set; }
        public Status Status { get; set; }

        public List<BestellingPizza> BestellingPizzas { get; set; }
    }
}
