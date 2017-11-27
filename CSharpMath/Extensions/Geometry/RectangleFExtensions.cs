﻿
using RectangleClass = System.Drawing.RectangleF;
using PointClass = System.Drawing.PointF;
using System;

namespace CSharpMath {
  public static class RectangleFExtensions{

    public static RectangleClass Plus(this RectangleClass rect, PointClass vector) {
      PointClass translatedLocation = rect.Location.Plus(vector);
      RectangleClass r = new RectangleClass(translatedLocation, rect.Size);
      return r;
    }

    public static RectangleClass Union(this RectangleClass rect1, RectangleClass rect2) {
      var x = Math.Min(rect1.X, rect2.X);
      var y = Math.Min(rect1.Y, rect2.Y);
      var maxX = Math.Max(rect1.Right, rect2.Right);
      var maxY = Math.Max(rect1.Bottom, rect2.Bottom);
      return new RectangleClass(x, y, maxX - x, maxY - y);
    }
  }
}
