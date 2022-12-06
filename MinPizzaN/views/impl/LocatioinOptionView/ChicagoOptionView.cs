using MinPizzaN.components.stores;
using MinPizzaN.constants;
using MinPizzaN.enums;
using MinPizzaN.models.ingredients;
using MinPizzaN.models.ingredients.factories;
using MinPizzaN.models.Menus;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.views.impl.LocatioinOptionView
{
    public class ChicagoOptionView : OptionView
    {
        private static Dictionary<int, PizzaOrderType> _pizzaOrderTypeByChoice = new Dictionary<int, PizzaOrderType>();

        public ChicagoOptionView(Menu optionMenu, PizzaStore pizzaStore) : base(optionMenu, pizzaStore)
        {
            InitializePizzaOptions();
        }

        private void InitializePizzaOptions()
        {
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Cheese_Pizza))
                _pizzaOrderTypeByChoice.Add(SystemConstant.Cheese_Pizza, PizzaOrderType.CheesePizza);
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Clam_Pizza))
                _pizzaOrderTypeByChoice.Add(SystemConstant.Clam_Pizza, PizzaOrderType.ClamPizza);
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Chicago_Pizza))
                _pizzaOrderTypeByChoice.Add(SystemConstant.Chicago_Pizza, PizzaOrderType.ChicagoPizza);
            
            if (!_pizzaOrderTypeByChoice.ContainsKey(SystemConstant.Sea_Food_Pizza))
                _pizzaOrderTypeByChoice.Add(SystemConstant.Sea_Food_Pizza, PizzaOrderType.SeaFoodPizza);
        }

        protected override void ProcessOptionMenu()
        {
            int choice;
            bool validChoice, isContinueOrdering;
            int optionsCount = optionMenu.Options.Count;
            do
            {
                Console.Clear();

                // Show list options menu
                optionMenu.ShowMenu();

                Console.Write("Please enter your choice: ");
                validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!validChoice)
                {
                    Console.WriteLine($"The choice invalid{Environment.NewLine}Please re-enter!!");
                }
                else if (choice < 0 || choice > optionsCount)
                {
                    Console.WriteLine("Please enter from 0 - " + optionMenu);
                }
                else if (choice == SystemConstant.Checkout)
                {
                    // Checkout shopping cart 
                    pizzaStore.Pay();
                }
                else
                {
                    SelectOption(choice);
                    Console.WriteLine("Order Pizza Successfully!!");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine($"Do you want to order ?{Environment.NewLine}Please press Y for continuing.");
                isContinueOrdering = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine();
            } while (validChoice && isContinueOrdering);

        }

        private void SelectOption(int choice)
        {
            pizzaStore.OrderPizza(_pizzaOrderTypeByChoice[choice]);
        }
    }
}
