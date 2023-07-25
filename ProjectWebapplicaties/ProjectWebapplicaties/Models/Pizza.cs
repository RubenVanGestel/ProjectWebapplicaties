using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; } 

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        //navigatieproperties

        public PizzaGrootte PizzaGrootte { get; set; }
    }
}
