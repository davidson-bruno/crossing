using System;
using System.Collections.Generic;
using System.Text;

namespace TheCrossingProblem
{
    class CommandException : Exception
    {
        public CommandException() : base("{!} Command not accepted.")
        {
        }
    }
}
