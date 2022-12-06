using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.toppings
{
    public abstract class ToppingsPizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public ToppingsPizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
