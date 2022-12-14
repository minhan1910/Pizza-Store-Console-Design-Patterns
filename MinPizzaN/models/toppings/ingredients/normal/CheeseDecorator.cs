using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.toppings.ingredients.normal
{
    public class CheeseDecorator : ToppingsPizzaDecorator
    {
        public CheeseDecorator(Pizza pizza)
            : base (pizza)
        {
        }

        public override string Name => pizza.Name + " + Cheese";

        public override double Cost => pizza.Cost + 2.00;

        public override void Prepare()
        {
        }
    }
}
