using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebapplicaties.Models
{
    public class PizzaGrootte
    {
        [Key]
        public int Id { get; set; }

        public string Naam { get; set; }

    }
}
