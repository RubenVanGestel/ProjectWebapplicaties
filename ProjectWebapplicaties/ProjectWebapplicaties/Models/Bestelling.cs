using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Bestelling
    {
        [Key]
        public int Id { get; set; }

        public int KlantId { get; set; }

        public int MedewerkerId { get; set; }

        public int StatusId { get; set; }

        public DateTime Datum { get; set; }

        public bool IsBezorging { get; set; }

        //navigatieproperties

        public Klant Klant { get; set; }
        public Medewerker Medewerker { get; set; }
        public Status Status { get; set; }  

    }
}
