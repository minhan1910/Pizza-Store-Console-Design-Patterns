using MinPizzaN.models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.Menus
{
    public class MixOptionMenu : Menu
    {
        public MixOptionMenu()
        {
            _option = new List<string>();
            InitializeMenuOptions();
        }

        protected override void InitializeMenuOptions()
        {
            _option.Add("1. Cheese ");
            _option.Add("2. Dough");
            _option.Add("3. Sauce");
            _option.Add("4. Extra Cheese");
            _option.Add("5. Special Dough");
            _option.Add("6. Checkout");
        }
    }
}
