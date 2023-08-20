using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; } 

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public int PizzaGrootteId { get; set; }

        //navigatieproperties
        public List<BestellingPizza> BestellingPizzas { get; set; }

    }
}
