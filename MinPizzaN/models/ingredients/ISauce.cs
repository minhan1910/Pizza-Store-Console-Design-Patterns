﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.ingredients
{
    public interface ISauce
    {
        string Name { get; }

        double Cost { get; }
    }
}
