﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using CSharpMath.Atoms;

namespace CSharpMath.Display {
  public class LargeOpLimitsDisplay : IDisplay {
    // A display representing the numerator of the fraction. Its position is relative
    // to the parent and it is not treated as a sub-display.
    public MathListDisplay UpperLimit { get; private set; }
    // A display representing the numerator of the fraction. Its position is relative
    // to the parent and it is not treated as a sub-display.
    public MathListDisplay LowerLimit { get; private set; }

    public RectangleF DisplayBounds => throw new NotImplementedException();

    public float Ascent => throw new NotImplementedException();

    public float Descent => throw new NotImplementedException();

    public float Width => throw new NotImplementedException();

    public Range Range => throw new NotImplementedException();

    public PointF Position => throw new NotImplementedException();

    public void Draw(IGraphicsContext context) => throw new NotImplementedException();
  }
}
