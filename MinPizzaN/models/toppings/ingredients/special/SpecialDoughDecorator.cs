using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.toppings
{
    public class SpecialDoughDecorator : ToppingsPizzaDecorator
    {
        public SpecialDoughDecorator(Pizza pizza)
            : base(pizza)
        {

        }
        public override string Name => pizza.Name + " + Special Dough";

        public override double Cost => pizza.Cost + 10.00;

        public override void Prepare()
        {
        }
    }
}
