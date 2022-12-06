using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients.impl.doughes
{
    public class ThickCrustDough : IDough
    {
        public string Name => "Thick Crust Dough";

        public double Cost => 2.20;
    }
}
