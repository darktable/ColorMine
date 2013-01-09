﻿using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    public class Xyz : ColorSpace
    {
        public double X { get { return this[0]; } set { this[0] = value; } }
        public double Y { get { return this[1]; } set { this[1] = value; } }
        public double Z { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            var r = PivotRgb(color.R/255.0);
            var g = PivotRgb(color.G/255.0);
            var b = PivotRgb(color.B/255.0);

            // Observer. = 2°, Illuminant = D65
            X = r*0.4124 + g*0.3576 + b*0.1805;
            Y = r*0.2126 + g*0.7152 + b*0.0722;
            Z = r*0.0193 + g*0.1192 + b*0.9505;
        }

        public override Color ToColor()
        {
            // (Observer = 2°, Illuminant = D65)
            var x = X/100;
            var y = Y/100;
            var z = Z/100;

            var r = x*3.2406 + y*-1.5372 + z*-0.4986;
            var g = x*-0.9689 + y*1.8758 + z*0.0415;
            var b = x*0.0557 + y*-0.2040 + z*1.0570;

            r = r > 0.0031308 ? 1.055*Math.Pow(r, 1/2.4) - 0.055 : 12.92*r;
            g = g > 0.0031308 ? 1.055*Math.Pow(g, 1/2.4) - 0.055 : 12.92*g;
            b = b > 0.0031308 ? 1.055*Math.Pow(b, 1/2.4) - 0.055 : 12.92*b;

            return Color.FromArgb(255, (int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private static double PivotRgb(double n)
        {
            return (n > 0.04045 ? Math.Pow((n + 0.055) / 1.055, 2.4) : n / 12.92) * 100;
        }
    }
}