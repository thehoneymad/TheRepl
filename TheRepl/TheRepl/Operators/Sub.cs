using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRepl.Operators
{
    public class Sub : Operator
    {
        public Sub()
        {
            Signature = "sub";
        }

        public override double Compute(double op1, double op2)
        {
            return op1 - op2;
        }
    }
}
