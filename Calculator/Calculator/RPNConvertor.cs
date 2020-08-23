﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Calculator
{
    class RPNConvertor
    {
        private IEnumerable<IRPNConvertable> Lexems { get; set; }
        public RPNConvertor(IEnumerable<IRPNConvertable> lexems)
        {
            Lexems = lexems;
        }
        public IEnumerable<Lexem> Convert ()
        {
            var signs = new Stack<Sign>();
            var polSeq = new LinkedList<Lexem>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNConvert(signs, polSeq);
            }

            while (signs.Count > 0)
            {
                polSeq.AddLast(signs.Peek());
                signs.Pop();
            }

            return polSeq;
        }
    }
}
