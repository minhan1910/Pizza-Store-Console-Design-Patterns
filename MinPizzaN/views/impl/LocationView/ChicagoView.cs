using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MinPizzaN.enums;
using MinPizzaN.models.Menus;
using MinPizzaN.views.impl.LocatioinOptionView;
using MinPizzaN.components.stores;
using MinPizzaN.constants;

namespace MinPizzaN.views.impl.LocationView
{
    public class ChicagoView : StoreLocationView
    {
        public ChicagoView(Menu orderMenu) : base(orderMenu)
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

        // Need to refactor logic for PizzaStore in ChicagoOptionView
        protected override void CreateOptionView(int option)
        {
            Console.Clear();

            optionView = new ChicagoOptionView(new OptionMenu(LocationType.Chicago),
                                                new ChicagoPizzaStore(
                                                    new ShoppingCart(optionView, this)));

            optionView.OptionPizzaStyleFromOrderView = option;
            optionView.RunView();
        }
    }
}
