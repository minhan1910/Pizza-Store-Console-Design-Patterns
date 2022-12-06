using MinPizzaN.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Menus
{
    public class OptionMenu : Menu
    {
        private LocationType _location;
        public OptionMenu(LocationType location)
        {
            this._location = location;
            _option = new List<string>();
            InitializeMenuOptions();
        }

        protected override void InitializeMenuOptions()
        {
            _option.AddRange(OptionalOptionMenu());
        }

        private string[] OptionalOptionMenu()
        {
            switch (_location)
            {
                case LocationType.Chicago:
                    return new string[] 
                    {
                        // - cheese, clam, chicago, sea food
                        "1. Cheese Pizza",
                        "2. Clam Pizza",
                        "3. Chicago Pizza",
                        "4. Sea Food Pizza",
                        "5. Checkout",
                    };
                case LocationType.NewYork:
                    return new string[]
                    {
                        "1. Cheese Pizza",
                        "2. Clam Pizza",
                        "3. New York Pizza",
                        "4. Sea Food Pizza",
                        "5. Checkout",
                    };

                default:
                    return new string[] { string.Empty };
            }
        }
    }
}
