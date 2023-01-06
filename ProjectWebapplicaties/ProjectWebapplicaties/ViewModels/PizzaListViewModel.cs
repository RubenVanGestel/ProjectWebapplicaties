using ProjectWebapplicaties.Models;
using System.Collections.Generic;

namespace ProjectWebapplicaties.ViewModels
{
    public class PizzaListViewModel
    {
        public List<Pizza> Pizzas { get; set; }
        public List<PizzaGrootte> Groottes { get; set; }
    }
}
