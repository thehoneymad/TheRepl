using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRepl.Operators;

namespace TheRepl
{
    public class ReplCore
    {
        public static double MemTotal = 0;
        static List<Operator> Ops;

        public ReplCore()
        {
            //Im practically cheating here by loading these, there should be a loader for these guys, then again, this is really really small
            Ops = new List<Operator>();
            Ops.Add(new Add());

        }

        public void Feed(OperationLine line)
        {
            //FIXME: Ive told before I havent put a postfix processor here so this whole segment would be a ghetto way to check
            //Unless I put a proper infix - postfix parser here and actually parse the whole repl this whole thing would never be able to actually start evaluating
            //full length expressions

            if (line.contents.Length > 1)
            {
                try
                {
                    var op = Ops.Where(x => x.Signature == line.contents.First()).FirstOrDefault();

                    var op2 = Double.Parse(line.contents[1]);

                    MemTotal = op.Compute(MemTotal, op2);
                    Print(MemTotal);
                }
                catch (Exception)
                {
                    Print("Invalid Command"); //FIXME: Bad stuff here, I should've made this string a const somewhere, lazy again
                }
            }
            else if (line.contents.Length == 1) //FIXME: I can definitely do an abstraction here making these things scalable because anyone would want to add a new command for the repl
            {
                switch (line.contents[0])
                {
                    case "show":
                        Print(MemTotal);
                        break;
                    case "clear":
                        MemTotal = 0;
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Print("Invalid Command");
                        break;
                }
            }
            else
            {
                Print(null);
            }
        }
        public void Print(object content)
        {
            Console.WriteLine(String.Concat("=> ", content));
        }
    }
}
