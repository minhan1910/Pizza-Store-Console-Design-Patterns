using MinPizzaN.constants;
using MinPizzaN.enums;
using MinPizzaN.models.Menus;
using MinPizzaN.views.impl.LocationView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace MinPizzaN.views.impl
{
    public class MainView : IView
    {
        [Description("Store Location View of Main View")]
        private StoreLocationView _storeLocationView;

        [Description("Main menu")]
        private Menu _mainMenu;

        private int menuCount;

        private static Dictionary<LocationType, StoreLocationView> IViewByLocationType;

        public MainView()
        {
            this._mainMenu = new MainMenu();
            InitializeLocationViewByLocationType();
            this.menuCount = IViewByLocationType.Count;
        }

        private void InitializeLocationViewByLocationType()
        {
            IViewByLocationType = new Dictionary<LocationType, StoreLocationView>();

            if (!IViewByLocationType.ContainsKey(LocationType.Chicago))
                IViewByLocationType.Add(LocationType.Chicago, new ChicagoView(
                                                                    new OrderMenu(
                                                                        LocationType.Chicago)));

            if (!IViewByLocationType.ContainsKey(LocationType.NewYork))
                IViewByLocationType.Add(LocationType.NewYork, new NewYorkView(
                                                                    new OrderMenu(
                                                                        LocationType.NewYork)));
        }

        public void RunView()
        {
            bool validChoice;
            int choice;
            do
            {
                Console.Clear();
                // Menu 
                _mainMenu.ShowMenu();

                // Choose the location menu
                Console.Write("The choice of the current location: ");
                validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (choice == SystemConstant.Exit)
                {
                    Console.Clear();
                    Console.WriteLine("See you again !!");
                    break;
                }

                if (!validChoice)
                {
                    Console.WriteLine("The choice invalid!!\n\"Please enter again!\"");
                    Console.ReadKey();
                }
                else if (choice < 0 || choice > menuCount)
                {
                    Console.Clear();
                    Console.WriteLine("The choice must enter from 0 - " + menuCount);
                }
                else 
                {
                    // Enter choice valid 
                    RegisterLocationMenu((LocationType)(choice - 1));
                }
            } while (!validChoice);
            
            
           
        }

        private void RegisterLocationMenu(LocationType location)
        {
            Console.Clear();
            _storeLocationView = IViewByLocationType[location];
            _storeLocationView.MainView = this;
            _storeLocationView.RunView();
        }
    }
}
