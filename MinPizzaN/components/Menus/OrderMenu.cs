using MinPizzaN.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Menus
{
    public class OrderMenu : Menu
    {
        private LocationType _location;

        public OrderMenu(LocationType location)
        {
            _option = new List<string>();
            _location = location;
            InitializeMenuOptions();
        }
        protected override void InitializeMenuOptions()
        {
            _option.AddRange(new string[]
            {
                "1. Pizza",
                OptionalMixPizzaMenu(),
                "0. Exit",
            });
        }

        private string OptionalMixPizzaMenu()
        {
            switch (_location)
            {
                case LocationType.Chicago: return string.Empty;
                case LocationType.NewYork: return "2. Mix Pizza";
                default: return string.Empty;
            }
        }
    }
}
