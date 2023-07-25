using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class BestellingPizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BestellingId { get; set; }

        public int Aantal { get; set; }

        //navigatieproperties

        public List<Pizza> Pizzas { get; set; }


    }
}
