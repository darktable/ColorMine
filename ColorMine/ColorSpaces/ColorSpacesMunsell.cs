using System;
using ColorMine.ColorSpaces.Conversions;
using System.Text.RegularExpressions;

namespace ColorMine.ColorSpaces
{
	public interface IMunsell : IColorSpace
	{

		MunsellHue H { get; set; }

		double V { get; set; }

		double C { get; set; }

		string ToString();
    }

	public class Munsell : ColorSpace, IMunsell
	{

		private MunsellHue _H;
		public MunsellHue H {
			get { return _H; }
			set {
				_H = value;
				if (value.Number > 10.0) {
					_H.Number = 10.0;
				}
				else if (value.Number < 0.0) {
					_H.Number = 0.0;
				}
			}
		}

		public double V { get; set; }

		public double C { get; set; }

		public override void Initialize(IRgb color) {
			MunsellConverter.ToColorSpace(color, this);
		}

		public override IRgb ToRgb() {
			return MunsellConverter.ToColor(this);
		}

		public Munsell() {}
		public Munsell(string munsellstr) : this() {
			SetMunsellString(munsellstr);
		}

		public void SetMunsellString(string munsellstr) {
			Regex regex;
			if (munsellstr[0] == 'N') {
				regex = new Regex(@"N([0-9.]+)");
				var m = regex.Match(munsellstr);
				if (!m.Success) throw new FormatException();
				this.H = new MunsellHue { Base = HueBase.N };
				this.V = double.Parse(m.Groups[1].Value);
			}
			else {
				regex = new Regex(@"([0-9.]+)([RYGBP]+)\s([0-9.]+)\/([0-9.]+)");
				var m = regex.Match(munsellstr);
				if (!m.Success) throw new FormatException();
				this.H = new MunsellHue(double.Parse(m.Groups[1].Value), (HueBase)Enum.Parse(typeof(HueBase), m.Groups[2].Value));
				this.V = double.Parse(m.Groups[3].Value);
				this.C = double.Parse(m.Groups[4].Value);
			}
		}

		public override string ToString() {
			if(H.Base == HueBase.N) {
				return string.Format("N{0,0:0.0}", Math.Round(V, 1, MidpointRounding.AwayFromZero));
			}

			return string.Format("{0,0:0.#}{1} {2,0:0.0}/{3,0:0.#}",
				Math.Round(H.Number, 1, MidpointRounding.AwayFromZero),
				H.Base.ToString(),
				Math.Round(V, 1, MidpointRounding.AwayFromZero),
				Math.Round(C, 1, MidpointRounding.AwayFromZero)
				);
        }

	}

	[Serializable]
	public enum HueBase
	{
		N,
		R,
		YR,
		Y,
		GY,
		G,
		BG,
		B,
		PB,
		P,
		RP
	}

	[Serializable]
	public class MunsellHue
	{

		public MunsellHue() { }
		public MunsellHue(double number, HueBase huebase) {
			this.Base = huebase;
			this.Number = number;
		}

		private double _Number;
		public double Number {
			get { return _Number; }
			set {
				if(this.Base == HueBase.N) {
					return;
				}
				if (value == 0.0) {
					this.Base = this.Base == HueBase.R ? HueBase.RP : this.Base - 1;
					_Number = 10.0;
				}
				else if(value > 10.0) {
					this.Base = this.Base == HueBase.RP ? HueBase.R : this.Base + 1;
					if (value > 20.0) {
						_Number = 10.0;
					}
					else {
						_Number = value - 10.0;
					}
				}
				else {
					_Number = value;
				}
			}
		}

		public HueBase Base { get; set; }

		public static bool operator !=(MunsellHue x, MunsellHue y) {
			if ((object)x == null || (object)y == null) {
				return (object)x != y;
			}
			else {
				return (x.Number != y.Number || x.Base != y.Base);
			}
		}

		public static bool operator ==(MunsellHue x, MunsellHue y) {
			if (Object.ReferenceEquals(x, y)) {
				return true;
			}
			if ((object)x == null || (object)y == null) {
				return (object)x == y;
			}
			else {
				return (x.Number == y.Number && x.Base == y.Base);
			}
		}
		public override bool Equals(object x) {
			return this == (MunsellHue)x;
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}
	}

}
