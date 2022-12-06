using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.toppings.ingredients.normal
{
    public class SauceDecorator : ToppingsPizzaDecorator
    {
        public SauceDecorator(Pizza pizza)
            : base (pizza)
        {

        }
        public override string Name => pizza.Name + " + Sauce";

        public override double Cost => pizza.Cost + 6.00;

        public override void Prepare()
        {
        }
    }
}
