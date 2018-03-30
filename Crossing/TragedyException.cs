using System;
using System.Collections.Generic;
using System.Text;

namespace TheCrossingProblem
{
    class TragedyException : Exception
    {
        public TragedyException(string agent1, string agent2) : base("{!} " + agent1 + " ate " + agent2)
        {
        }
    }
}
