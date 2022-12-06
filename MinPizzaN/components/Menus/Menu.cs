using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Menus
{
    public abstract class Menu
    {
        protected List<string> _option;
        protected abstract void InitializeMenuOptions();
        public virtual void ShowMenu()
        {
            foreach (var option in _option)
                if (HasOption(option))
                    Console.WriteLine(option);
        }
        private bool HasOption(string option)
        {
            return (null != option && option != string.Empty);
        }
        public List<string> Options { get { return _option; } }
    }
}
