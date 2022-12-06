using MinPizzaN.enums;
using MinPizzaN.models.Pizzas;
using MinPizzaN.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.stores
{
    public abstract class PizzaStore
    {
        protected Pizza pizza;
        protected ShoppingCart _shoppingCart;
        
        public PizzaStore(ShoppingCart shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }
        protected abstract Pizza CreatePizza(PizzaOrderType pizzaOrderType);

        public virtual void CreateMixPizza(PizzaMixOrderType pizzaMixType)
        {
        }
        public abstract string Name { get; }

        public virtual void OrderPizza(PizzaOrderType pizzaOrderType)
        {
            pizza = CreatePizza(pizzaOrderType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            _shoppingCart.AddProduct(pizza);
        }

        public virtual void OrderMixPizza()
        {
          
        }

        public void Pay()
        {
            _shoppingCart.Pay();
        }

    }
}
