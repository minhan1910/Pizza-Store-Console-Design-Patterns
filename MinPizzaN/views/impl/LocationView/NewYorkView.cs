using MinPizzaN.components.Menus;
using MinPizzaN.components.stores;
using MinPizzaN.constants;
using MinPizzaN.enums;
using MinPizzaN.models.Menus;
using MinPizzaN.models.Pizzas;
using MinPizzaN.views.impl.LocatioinOptionView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.views.impl.LocationView
{
    public class NewYorkView : StoreLocationView
    {
        public NewYorkView(Menu orderMenu) : base(orderMenu)
        {
        }

        protected override void ProcessLocationView()
        {
            bool validChoice;
            int choice;
            var optionsOrderMenu = orderMenu.Options.Count;

            do
            {
                Console.Clear();
                // Show menu
                orderMenu.ShowMenu();

                // Choose your choice
                Console.Write("Please enter your choice: ");
                validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (choice == SystemConstant.Exit)
                {
                    Console.Clear();
                    Console.WriteLine("See you again !!");
                    break;
                }

                if (!validChoice)
                {
                    Console.WriteLine("The choice invalid\nPlease re-enter");
                }
                else if (choice < 0 || choice > optionsOrderMenu)
                {
                    Console.WriteLine("Please enter from 0 - " + optionsOrderMenu);
                }
                else
                {
                    CreateOptionView(choice);
                }

            } while (!validChoice);
        }
        protected override void CreateOptionView(int option)
        {
            Console.Clear();
            optionView = new NewYorkOptionView(new OptionMenu(LocationType.NewYork),
                                                new MixOptionMenu(),
                                                new NewYorkPizzaStore(
                                                    new ShoppingCart(optionView, this)));

            // Distinguish between original pizza / mix pizza
            optionView.OptionPizzaStyleFromOrderView = option;
            
            optionView.RunView();
        }
    }
}
