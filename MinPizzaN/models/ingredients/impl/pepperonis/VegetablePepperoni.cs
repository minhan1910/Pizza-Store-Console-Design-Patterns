using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients.impl.pepperonis
{
    public class VegetablePepperoni : IPepperoni
    {
        public string Name => "Vegetable Pepperoni";

        public double Cost => 2.10;
    }
}
