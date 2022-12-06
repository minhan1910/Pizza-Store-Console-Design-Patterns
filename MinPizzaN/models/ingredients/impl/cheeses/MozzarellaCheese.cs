using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients.impl.cheeses
{
    public class MozzarellaCheese : ICheese
    {
        public string Name { get => "Mozzarella Cheese"; }

        public double Cost => 2.00;
    }
}
