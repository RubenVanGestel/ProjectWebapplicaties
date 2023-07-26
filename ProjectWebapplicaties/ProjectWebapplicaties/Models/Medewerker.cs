using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Medewerker
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Naam { get; set; }

        [MaxLength(50)]
        public string Voornaam { get; set; }

        [MaxLength(50)]
        public string Straatnaam { get; set; }

        [MaxLength(10)]
        public string Huisnummer { get; set; }

        [MaxLength(10)]
        public string Postcode { get; set; }

        [MaxLength(50)]
        public string Gemeente { get; set; }

        [MaxLength(50)]
        public string EmailAdres { get; set; }
    }
}
