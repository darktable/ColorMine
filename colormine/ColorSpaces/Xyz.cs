﻿using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    internal class Xyz : ColorSpace
    {
        public double X { get { return this[0]; } set { this[0] = value; } }
        public double Y { get { return this[1]; } set { this[1] = value; } }
        public double Z { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            throw new NotImplementedException();
        }

        public override Color ToColor()
        {
            throw new NotImplementedException();
        }
    }
}