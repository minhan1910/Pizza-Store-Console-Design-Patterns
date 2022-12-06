using MinPizzaN.components.stores;
using MinPizzaN.models.ingredients.factories;
using MinPizzaN.models.ingredients;
using MinPizzaN.models.Menus;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinPizzaN.enums;
using MinPizzaN.constants;

namespace MinPizzaN.views.impl.LocatioinOptionView
{
    public class NewYorkOptionView : OptionView
    {   
        private static PizzaIngredientFactory _newYorkPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

        private static Dictionary<int, PizzaOrderType> _pizzaOrderTypeByChoice = new Dictionary<int, PizzaOrderType>();
        private static Dictionary<int, PizzaMixOrderType> _pizzaMixOrderTypeByChoice = new Dictionary<int, PizzaMixOrderType>();

        private Menu _mixOptionMenu;

        public NewYorkOptionView(Menu optionMenu, Menu mixOptionMenu, PizzaStore pizzaStore) : base(optionMenu, pizzaStore)
        {
            _mixOptionMenu = mixOptionMenu;
            InitializePizzaOptions();
            InitializeMixPizzaOptions();
        }

        private void InitializePizzaOptions()
        {
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Cheese_Pizza)) 
                _pizzaOrderTypeByChoice.Add(SystemConstant.Cheese_Pizza, PizzaOrderType.CheesePizza);
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Clam_Pizza)) 
                _pizzaOrderTypeByChoice.Add(SystemConstant.Clam_Pizza, PizzaOrderType.ClamPizza);
            
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.New_York_Pizza)) 
                _pizzaOrderTypeByChoice.Add(SystemConstant.New_York_Pizza, PizzaOrderType.NewYorkPizza);
            
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Sea_Food_Pizza)) 
                _pizzaOrderTypeByChoice.Add(SystemConstant.Sea_Food_Pizza, PizzaOrderType.SeaFoodPizza);
        }

        private void InitializeMixPizzaOptions()
        {
            if (!_pizzaMixOrderTypeByChoice.ContainsKey(SystemConstant.Mix_Cheese))
                _pizzaMixOrderTypeByChoice.Add(SystemConstant.Mix_Cheese, PizzaMixOrderType.Cheese);

            if (!_pizzaMixOrderTypeByChoice.ContainsKey(SystemConstant.Mix_Dough))
                _pizzaMixOrderTypeByChoice.Add(SystemConstant.Mix_Dough, PizzaMixOrderType.Dough);

            if (!_pizzaMixOrderTypeByChoice.ContainsKey(SystemConstant.Mix_Sauce))
                _pizzaMixOrderTypeByChoice.Add(SystemConstant.Mix_Sauce, PizzaMixOrderType.Sauce);

            if (!_pizzaMixOrderTypeByChoice.ContainsKey(SystemConstant.Mix_Extra_Cheese))
                _pizzaMixOrderTypeByChoice.Add(SystemConstant.Mix_Extra_Cheese, PizzaMixOrderType.Extra_Cheese);

            if (!_pizzaMixOrderTypeByChoice.ContainsKey(SystemConstant.Mix_Special_Dough))
                _pizzaMixOrderTypeByChoice.Add(SystemConstant.Mix_Special_Dough, PizzaMixOrderType.Special_Dough);
        }

        protected override void ProcessOptionMenu()
        {
            int choice;
            bool validChoice, isContinueOrdering;
            int optionsCount = optionMenu.Options.Count;
            int mixOptionsCount = _mixOptionMenu.Options.Count;
            do
            {
                Console.Clear();

                // Show list options menu by optionFromOrderView
                ShowStylePizzaMenuOption();

                Console.Write("Please enter your choice: ");
                validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (choice == SystemConstant.Exit)
                {
                    Console.Clear();
                    Console.WriteLine("See you agin!!");
                    break;
                }

                if (!validChoice)
                {
                    Console.WriteLine($"The choice invalid{Environment.NewLine}Please re-enter!!");
                }
                else if (OptionPizzaStyleFromOrderView == SystemConstant.NewYork_Mix_Pizza)
                {
                    if (choice < 0 || choice > mixOptionsCount)
                    {
                        Console.WriteLine("Please enter from 0 - " + optionMenu);
                    }
                    else if (choice == SystemConstant.MixCheckout)
                    {
                        // Checkout shopping cart 
                        pizzaStore.OrderMixPizza();
                        pizzaStore.Pay();
                    } else
                    {
                        // the problem is mix pizza feature
                        // Handling choose original pizza and mix pizza
                        PickStylePizzaOption(choice);
                    }
                }
                else if (OptionPizzaStyleFromOrderView == SystemConstant.NewYork_Original_Pizza)
                {
                    if (choice < 0 || choice > optionsCount)
                    {
                        Console.WriteLine("Please enter from 0 - " + optionMenu);
                    }
                    else if (choice == SystemConstant.Checkout )
                    {
                        // Checkout shopping cart 
                        pizzaStore.Pay();
                    } else
                    {
                        // the problem is mix pizza feature
                        // Handling choose original pizza and mix pizza
                        PickStylePizzaOption(choice);
                    }
                }
                

                Console.WriteLine($"Do you want continue to order ?{Environment.NewLine}Please press Y for continuing.");
                isContinueOrdering = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (validChoice && isContinueOrdering);
        }

        private void SelectOriginalPizzaOption(int choice)
        {
            pizzaStore.OrderPizza(_pizzaOrderTypeByChoice[choice]); 
        }
        
        private void SelectMixPizzaOption(int choice)
        {
            // Different logic
            pizzaStore.CreateMixPizza(_pizzaMixOrderTypeByChoice[choice]);
        }

        private void ShowStylePizzaMenuOption()
        {
            switch (OptionPizzaStyleFromOrderView)
            {
                case SystemConstant.NewYork_Original_Pizza:
                    optionMenu.ShowMenu();
                    break;

                case SystemConstant.NewYork_Mix_Pizza:
                    _mixOptionMenu.ShowMenu();
                    break;

                default:
                    break;
            }
        }

        private void PickStylePizzaOption(int choice)
        {
            switch ((PizzaStyleOptionType) OptionPizzaStyleFromOrderView)
            {
                case PizzaStyleOptionType.Pizza:
                    SelectOriginalPizzaOption(choice);
                    break;
                case PizzaStyleOptionType.MixPizza:
                    SelectMixPizzaOption(choice);   
                    break;
                default:
                    break;
            }
        }
    }
}
