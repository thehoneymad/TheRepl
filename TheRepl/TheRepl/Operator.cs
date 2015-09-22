using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRepl
{
    public abstract class Operator
    {
        public string Signature { get; set; }
        public abstract double Compute(double op1, double op2); 
        //INFO: I know this can be made better but at this point Im too lazy or too tired to even go for it. Generics might be of help.
        //Although it looks a bit overwhelming if at any point someone wants to add a unary operator he would be able to, all we have to do is ignore the second op
        //then again, this expression parser is not technically a proper infix-postfix parser anyway, so that has to be in place first. 

    }
}
