using MinPizzaN.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.components.payment
{
    public interface PaymentStrategy<T>
    {
        void Pay();
        List<T> Products { set; }
        //T Product { set; }
    }
}
