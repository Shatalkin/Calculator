﻿using System;

namespace Calculator
{
    internal class ModulFunction : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Abs(args[0]);
        }
    }
}