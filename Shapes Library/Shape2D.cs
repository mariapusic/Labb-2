﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public abstract class Shape2D : Shape
    {
        public abstract float Circumference { get; }
        
    }
}
