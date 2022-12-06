using MinPizzaN.components.stores;
using MinPizzaN.models.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.views.impl
{
    public abstract class OptionView : IView
    {

        protected Menu optionMenu;
        protected PizzaStore pizzaStore;
        public int OptionPizzaStyleFromOrderView { get; set; }
        public OptionView(Menu optionMenu, PizzaStore pizzaStore)
        {
            this.optionMenu = optionMenu;
            this.pizzaStore = pizzaStore;
        }

        public virtual void RunView()
        {
            ProcessOptionMenu();
        }

        protected abstract void ProcessOptionMenu();

    }
}
