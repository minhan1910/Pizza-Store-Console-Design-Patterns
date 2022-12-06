using MinPizzaN.models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.views.impl
{
    public class InvoiceView : IView
    {
        private IView _orderView;
        public InvoiceView(IView orderView)
        {
            _orderView = orderView;
        }

        public List<Pizza> Pizzas { get; set; }

        public void RunView()
        {
            PrintInvoice();
        }
        private void PrintInvoice()
        {
            // pizza name, cost
            // total cost
            Console.Clear();
            bool isContinue;
            double totalCost = 0;

            foreach (var pizza in Pizzas)
            {
                Console.WriteLine($"Pizza name: {pizza.Name}");
                Console.WriteLine($"Pizza cost: {pizza.Cost}");
                totalCost += pizza.Cost;
                Console.WriteLine();
            }

            Console.WriteLine($"Total Cost: {totalCost}");

            Console.WriteLine("Do you want to continue to order?");
            Console.WriteLine("Press Y for continuing.");
            isContinue = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase);

            if (isContinue)
                BackToOrderView();
        }

        public void BackToOrderView()
        {
            _orderView.RunView();
        }
    }
}
