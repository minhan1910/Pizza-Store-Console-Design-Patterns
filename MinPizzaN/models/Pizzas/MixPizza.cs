using MinPizzaN.models.ingredients;
using MinPizzaN.models.toppings;
using MinPizzaN.models.toppings.ingredients.normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Pizzas
{
    public class MixPizza : Pizza
    {
        public MixPizza()
        {
        }

        public override string Name => "Mix Pizza";

        public override void Prepare()
        {
        }

        public override double Cost { get { return 0; } }
    }
}
