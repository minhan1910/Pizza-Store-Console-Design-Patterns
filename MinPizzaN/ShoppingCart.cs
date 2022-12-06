using MinPizzaN.models.Pizzas;
using MinPizzaN.views;
using MinPizzaN.views.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN
{
    public class ShoppingCart
    {
        private OptionView _optionView;

        [Description("Payment View")]
        private PaymentView _paymentView;

        [Description("Order View")]
        private IView _orderView;
        
        private List<Pizza> pizzas = new List<Pizza>();
        public ShoppingCart(OptionView optionView, IView orderView)
        {
            _orderView = orderView;
            this._optionView  = optionView;
            _paymentView = new PaymentView(orderView); 
        }

        public void AddProduct(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public void RemoveProduct(Pizza pizza)
        {
            pizzas.Remove(pizza);
        }

        public void Pay() 
        {
            // pass props 
            _paymentView.Pizzas = pizzas;
            //_paymentView.MixPizza = 
            _paymentView.RunView();
        }

        public void BackToOptionView()
        {
            _optionView.RunView();
        }
    }
}
