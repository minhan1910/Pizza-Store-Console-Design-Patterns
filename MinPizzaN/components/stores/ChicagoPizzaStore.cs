using MinPizzaN.constants;
using MinPizzaN.enums;
using MinPizzaN.models.ingredients;
using MinPizzaN.models.ingredients.factories;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.stores
{
    public class ChicagoPizzaStore : PizzaStore
    { 
        private static Dictionary<PizzaOrderType, Pizza> _pizzaByPizzaOrderType = new Dictionary<PizzaOrderType, Pizza>();
        private static PizzaIngredientFactory _chicagoPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        public ChicagoPizzaStore(ShoppingCart shoppingCart) : base(shoppingCart) 
        {
            InitalizePizzaOrderType();  
        }
        public override string Name => "Chicago Pizza Store";

        protected override Pizza CreatePizza(PizzaOrderType pizzaOrderType)
        {
            return _pizzaByPizzaOrderType[pizzaOrderType];
        }

        private void InitalizePizzaOrderType()
        {
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.CheesePizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.CheesePizza, new CheesePizza(_chicagoPizzaIngredientFactory));
            
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.ClamPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.ClamPizza, new ClamPizza(_chicagoPizzaIngredientFactory));

            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.ChicagoPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.ChicagoPizza, new ChicagoPizza(_chicagoPizzaIngredientFactory));
            
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.SeaFoodPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.SeaFoodPizza, new SeaFoodPizza(_chicagoPizzaIngredientFactory));
        }
    }
}
