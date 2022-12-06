using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Menus
{
    public class MainMenu : Menu
    {
        public MainMenu()
        {
            _option = new List<string>();
            InitializeMenuOptions();
        }

        protected override void InitializeMenuOptions()
        {
            _option.Add("1. Chicago");
            _option.Add("2. New York");
            _option.Add("0. Exit");
        }        
    }
}
