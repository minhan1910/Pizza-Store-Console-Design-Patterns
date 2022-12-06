using MinPizzaN.components.payment;
using MinPizzaN.enums;
using MinPizzaN.models.Menus;
using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.views.impl
{

    // Singleton
    public class PaymentView : IView
    {
        private IView _orderView;
        private Menu _paymentMenu;
        private int _paymentMenuCount;
        private PaymentHandler _paymentHandler;

        public PaymentView(IView orderView)
        {
            _orderView = orderView;
            _paymentMenu = new PaymentMenu();
            _paymentMenuCount = _paymentMenu.Options.Count;
            _paymentHandler = new PaymentHandler(_orderView);
        }
        public void RunView()
        {
            bool validChoice;
            int choice;
            do
            {
                Console.Clear();    
                _paymentMenu.ShowMenu();

                Console.Write("Please Enter Your Payment: ");
                validChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!validChoice)
                {
                    Console.WriteLine($"The Choice Invalid{Environment.NewLine}Plesae Re-enter");
                    Console.WriteLine();
                }
                else if (choice < 0 || choice > _paymentMenuCount)
                {
                    Console.WriteLine("Please enter from 0 - " + _paymentMenuCount);
                    Console.WriteLine();
                } 
                else
                {
                    ProcessPayment(choice);
                }

            } while (!validChoice);
        }

        private void ProcessPayment(int choice)
        {
            // ToDo process payment
            Console.WriteLine("Payment choice =>>> " + choice);
            _paymentHandler.Pizzas = Pizzas;
            _paymentHandler.Pay((PaymentType)choice - 1);
        }

        // Get props from Shopping Cart
        public List<Pizza> Pizzas { get; set; }

        public Pizza MixPizza { get; set; }
    }
}
