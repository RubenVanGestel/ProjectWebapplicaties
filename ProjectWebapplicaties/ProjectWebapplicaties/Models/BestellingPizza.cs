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

        [Required]
        public int PizzaId { get; set; }

        public int Aantal { get; set; }

        //navigatieproperties

        public Bestelling Bestelling { get; set; }
        public List<Pizza> Pizzas { get; set; }


    }
}
