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

        public int PizzaId { get; set; }

        //navigatieproperties

        public Bestelling Bestelling { get; set; }
        public Pizza Pizzas { get; set; }

    }
}
