using System;
using System.Collections.Generic;
using System.Text;

namespace TheCrossingProblem
{
    class SameSideException : Exception
    {
        public SameSideException(string agent1, string agent2) : base("{!} " + agent1 + " and " + agent2 + " are not in the same side!")
        {
        }
    }
}
