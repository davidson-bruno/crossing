using System;
using System.Collections.Generic;
using System.Text;

namespace TheCrossingProblem
{
    static class Side
    {
        public const bool left = false;
        private const bool right = true;

        public static bool Left => left;
        public static bool Right => right;
    }
}
