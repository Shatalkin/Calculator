﻿using System;

namespace Calculator
{
    internal class Exponent : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Exp(args[0]);
        }
    }
}