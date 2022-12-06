using MinPizzaN.models.ingredients.impl.cheeses;
using MinPizzaN.models.ingredients.impl.clams;
using MinPizzaN.models.ingredients.impl.doughes;
using MinPizzaN.models.ingredients.impl.pepperonis;
using MinPizzaN.models.ingredients.impl.sauces;
using MinPizzaN.models.ingredients.impl.veggies;
using MinPizzaN.models.toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients.factories
{
    public class NewYorkPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override IClams CreateClams()
        {
            return new FreshClams();
        }

        public override IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public override IPepperoni CreatePepperoni()
        {
            return new VegetablePepperoni();
        }

        public override ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public override List<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>
            {
                new OnionVeggie(),
                new SaladVeggie(),
                new Mushroom()
            };
        }
    }
}
