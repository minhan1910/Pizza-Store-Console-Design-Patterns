using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients.impl.veggies
{
    public class Mushroom : IVeggies
    {
        public string Name => "Mushroom";

        public double Cost => 2.00;
    }
}
