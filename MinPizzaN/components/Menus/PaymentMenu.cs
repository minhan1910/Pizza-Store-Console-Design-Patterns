using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Menus
{
    public class PaymentMenu : Menu
    {
        public PaymentMenu()
        {
            _option = new List<string>();
            InitializeMenuOptions();
        }

        protected override void InitializeMenuOptions()
        {
            _option.Add("1. Credit Crad");
            _option.Add("2. Paypal ");
            _option.Add("0. Exit");
        }
    }
}
