using MinPizzaN.enums;
using MinPizzaN.models.ingredients.factories;
using MinPizzaN.models.ingredients;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinPizzaN.views;
using MinPizzaN.models.toppings.ingredients.normal;
using MinPizzaN.models.toppings;

namespace MinPizzaN.components.stores
{
    public class NewYorkPizzaStore : PizzaStore
    {
        private Pizza mixPizza = new MixPizza();
        private static Dictionary<PizzaOrderType, Pizza> _pizzaByPizzaOrderType = new Dictionary<PizzaOrderType, Pizza>();
        private static PizzaIngredientFactory _newYorkPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        public NewYorkPizzaStore(ShoppingCart shoppingCart) : base(shoppingCart)
        {
            InitalizePizzaOrderType();
        }
        public override string Name => "New York Pizza Store";
        
        public override void CreateMixPizza(PizzaMixOrderType pizzaMixOrderType)
        {
            switch (pizzaMixOrderType)
            {
                case PizzaMixOrderType.Cheese:
                    mixPizza = new CheeseDecorator(mixPizza);
                    break;
                case PizzaMixOrderType.Dough:
                    mixPizza = new DoughDecorator(mixPizza);
                    break;
                case PizzaMixOrderType.Sauce:
                    mixPizza = new SauceDecorator(mixPizza);
                    break;
                case PizzaMixOrderType.Extra_Cheese:
                    mixPizza = new ExtraCheeseDecorator(mixPizza);
                    break;
                case PizzaMixOrderType.Special_Dough:
                    mixPizza = new SpecialDoughDecorator(mixPizza);
                    break;
                default:
                    break;
            }
        }

        public override void OrderMixPizza()
        {
            mixPizza.Prepare();
            _shoppingCart.AddProduct(mixPizza);
        }

        protected override Pizza CreatePizza(PizzaOrderType pizzaOrderType)
        {
            return _pizzaByPizzaOrderType[pizzaOrderType];
        }

        private void InitalizePizzaOrderType()
        {
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.CheesePizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.CheesePizza, new CheesePizza(_newYorkPizzaIngredientFactory));
            
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.ClamPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.ClamPizza, new ClamPizza(_newYorkPizzaIngredientFactory));
            
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.NewYorkPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.NewYorkPizza, new NewYorkPizza(_newYorkPizzaIngredientFactory));
            
            if (!_pizzaByPizzaOrderType.ContainsKey(PizzaOrderType.SeaFoodPizza))
                _pizzaByPizzaOrderType.Add(PizzaOrderType.SeaFoodPizza, new SeaFoodPizza(_newYorkPizzaIngredientFactory));
        }
    }
}
