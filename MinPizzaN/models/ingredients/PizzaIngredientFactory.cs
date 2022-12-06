using MinPizzaN.models.toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients
{
    public abstract class PizzaIngredientFactory
    {
        public abstract IDough CreateDough();
        public abstract ISauce CreateSauce();
        public abstract IPepperoni CreatePepperoni();
        public abstract List<IVeggies> CreateVeggies();
        public abstract IClams CreateClams();
        public abstract ICheese CreateCheese();
    }
}
