using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.toppings.ingredients.normal
{
    public class DoughDecorator : ToppingsPizzaDecorator
    {
        public DoughDecorator(Pizza pizza)
            : base(pizza)
        {

        }
        public override string Name => pizza.Name + " + Dough";

        public override double Cost => pizza.Cost + 4.00;

        public override void Prepare()
        {
        }
    }
}
