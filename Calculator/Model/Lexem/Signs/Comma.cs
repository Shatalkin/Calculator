﻿using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Comma : Sign, ILBracket, IRBracket
    {
        protected internal override Priority Priority => Priority.AsBracket;

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            throw new NotImplementedException();
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            while (signs.Peek() is ILBracket == false)
            {
                lexems.AddLast(signs.Pop());
            }
            signs.Pop();
            signs.Push(this);
        }
    }
}