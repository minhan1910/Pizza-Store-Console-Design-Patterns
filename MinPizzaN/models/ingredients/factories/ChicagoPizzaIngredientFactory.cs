
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MinPizzaN.models.ingredients.impl.cheeses;
using MinPizzaN.models.ingredients.impl.clams;
using MinPizzaN.models.ingredients.impl.doughes;
using MinPizzaN.models.ingredients.impl.pepperonis;
using MinPizzaN.models.ingredients.impl.sauces;
using MinPizzaN.models.ingredients.impl.veggies;

namespace MinPizzaN.models.ingredients.factories
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public override IClams CreateClams()
        {
            return new FrozenClams();
        }

        public override IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override IPepperoni CreatePepperoni()
        {
            return new GustoPepperoni();
        }

        public override ISauce CreateSauce()
        {
            return new MarianaSauce();
        }

        public override List<IVeggies> CreateVeggies()
        {
            return new List<IVeggies> 
            {
                new OnionVeggie(),
                new SaladVeggie(),
                new RedPepperVeggie(),
                new GarlicVeggie(),
            };
        }
    }
}
