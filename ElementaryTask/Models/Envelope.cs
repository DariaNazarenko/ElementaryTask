﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EnvelopeTask.Models
{
    class Envelope 
    {
        public double Side1 { get; }
        public double Side2 { get; }

        public Envelope(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
    }
}
