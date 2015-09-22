using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRepl
{
    public class OperationLine
    {
        public string[] contents { get; set; }
        public OperationLine(string cmdLine)
        {
            contents = cmdLine.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
