using MinPizzaN.models.ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Pizzas
{
    public class ClamPizza : Pizza
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public ClamPizza(PizzaIngredientFactory _pizzaIngredientFactory)
        {
            this._pizzaIngredientFactory = _pizzaIngredientFactory;
        }
        public override string Name => "Clam Pizza";
        public override void Prepare()
        {
            base._dough = _pizzaIngredientFactory.CreateDough();
            base._cheese = _pizzaIngredientFactory.CreateCheese();
            base._clam = _pizzaIngredientFactory.CreateClams();
            base._pepperoni = _pizzaIngredientFactory.CreatePepperoni();
            base._sauce = _pizzaIngredientFactory.CreateSauce();
            base._veggies = _pizzaIngredientFactory.CreateVeggies();
        }

       
    }
}
