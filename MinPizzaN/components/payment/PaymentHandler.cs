using MinPizzaN.enums;
using MinPizzaN.models.Pizzas;
using MinPizzaN.views;
using MinPizzaN.views.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.payment
{
    public class PaymentHandler
    {
        private PaymentStrategy<Pizza> _paymentStrategy;
        private IView _orderView;
        public PaymentHandler(IView orderView) 
        {
            _orderView = orderView;
        }

        public List<Pizza> Pizzas { get; set; } 
        
        public void Pay(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    _paymentStrategy = new CreditCardPayment(_orderView);
                    _paymentStrategy.Products = Pizzas;
                    _paymentStrategy.Pay();
                    break;

                case PaymentType.Paypal:
                    _paymentStrategy = new PaypalPayment(_orderView);
                    _paymentStrategy.Products = Pizzas;
                    _paymentStrategy.Pay();
                    break;
                default:
                    break;
            }
        }
    }
}
