using MinPizzaN.models.Pizzas;
using MinPizzaN.views.impl;
using MinPizzaN.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.payment
{
    public class PaypalPayment : PaymentStrategy<Pizza>
    {
        private List<Pizza> _pizzas;

        private IView _orderView;

        private InvoiceView _invoiceView;

        public PaypalPayment(IView orderView)
        {
            _orderView = orderView;
            _invoiceView = new InvoiceView(_orderView);
        }

        public List<Pizza> Products { set => _pizzas = value; }
        public void Pay()
        {
            Console.WriteLine(">>>>>Using Paypal Card Successfully<<<<<");
            _invoiceView.Pizzas = _pizzas;
            _invoiceView.RunView();
        }
    }
}
