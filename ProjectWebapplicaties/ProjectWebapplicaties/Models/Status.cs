using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        //navigatieproperties
        public List<Bestelling> Bestellingen { get; set; }
    }
}
