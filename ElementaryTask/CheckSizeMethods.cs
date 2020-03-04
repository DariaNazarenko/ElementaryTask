﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnvelopeTask
{
    class CheckSizeMethods
    {
        public static bool SimpleIfChecking(Envelope env1, Envelope env2)
        {
            return (env1.Side1 < env2.Side1 && env1.Side2 < env2.Side2 ||
                env1.Side1 < env2.Side2 && env1.Side2 < env2.Side1 ||
                env2.Side1 < env1.Side1 && env2.Side2 < env1.Side2 ||
                env2.Side1 < env1.Side2 && env2.Side2 < env1.Side1);
        }
    }
}
