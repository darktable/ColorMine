using ColorMine.ColorSpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMineAddMunsell.Test.ColorSpaces
{
	public class MunsellTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void WhiteMunsellToRgb() {
				var knownColor = new Munsell("N10"); 
				var expectedColor = new Rgb { R = 255, G = 255, B = 255, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void BlackMunsellToRgb() {
				var knownColor = new Munsell("N0");
				var expectedColor = new Rgb { R = 0, G = 0, B = 0, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void GoldenrodMunsellToRgb() {
				var knownColor = new Munsell("2.5Y 7/10");
				var expectedColor = new Rgb { R = 221, G = 167, B = 44, };	//D65 apply value

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void SteelBlueMunsellToCmy() {
				var knownColor = new Munsell("2.5PB 5/8");
				var expectedColor = new Cmy { C = .72549, M = .49020, Y = .29412, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void AliceBlueMunsellToHsl() {
				var knownColor = new Munsell("2PB 9.61/0.99");
				var expectedColor = new Hsl { H = 208, S = 100, L = 97, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void RedMunsellToLab() {
				var knownColor = new Munsell("7.5R 5/20");
				var expectedColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void RivergumMunsellToXyz() {
				var knownColor = new Munsell("7.5GY 4/2");
				var expectedColor = new Xyz { X = 13.123, Y = 15.372, Z = 13.174, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void AquamarineMunsellToHsb() {
				var knownColor = new Munsell("7.5G 9/8");
				var expectedColor = new Hsb { H = 160, S = .5, B = 1, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
    }

	public class HexTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void WhiteHexToRgb() {
				var knownColor = new Hex("#FFFFFF");
				var expectedColor = new Rgb { R = 255, G = 255, B = 255, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void GoldenrodHexToRgb() {
				var knownColor = new Hex("#daa520"); 
				var expectedColor = new Rgb { R = 218, G = 165, B = 32, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void MaroonHexToLch() {
				var knownColor = new Hex("7d0000");
				var expectedColor =  new Lch { L = 24.829, C = 60.093, H = 38.180, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void RivergumHexToXyz() {
				var knownColor = new Hex("62715F"); 
				var expectedColor = new Xyz { X = 13.123, Y = 15.372, Z = 13.174, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void AquamarineHexToHsb() {
				var knownColor = new Hex("80FFD4"); 
				var expectedColor = new Hsb { H = 160, S = .5, B = 1, };

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}
	public class RgbTest
	{

		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void WhiteRgbToMunsell() {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Munsell("N10");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

		
			[TestMethod]
			public void BlackRgbToMunsell() {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Munsell("N0");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void GoldenrodRgbToMunsell() {
				var knownColor = new Rgb { R = 218, G = 165, B = 32, };
				var expectedColor = new Munsell("2.5Y 7/10");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void WhiteRgbToHex() {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Hex("#FFFFFF");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void BlackRgbToHex() {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Hex("#000000");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void GoldenrodRgbToHex() {
				var knownColor = new Rgb { R = 218, G = 165, B = 32, };
				var expectedColor = new Hex("#daa520");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class CmyTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{


			[TestMethod]
			public void SteelBlueCmyToMunsell() {
				var knownColor = new Cmy { C = .72549, M = .49020, Y = .29412, };
				var expectedColor = new Munsell("2.5PB 5/8");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void SteelBlueCmyToHex() {
				var knownColor = new Cmy { C = .72549, M = .49020, Y = .29412, };
				var expectedColor = new Hex("#4682B4");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class CmykTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{


			[TestMethod]
			public void DarkVioletCmykToMunsell() {
				var knownColor = new Cmyk { C = .29858, M = 1, Y = 0, K = .17255, };
				var expectedColor = new Munsell("2.5P 4/24");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void DarkVioletCmykToHex() {
				var knownColor = new Cmyk { C = .29858, M = 1, Y = 0, K = .17255, };
				var expectedColor = new Hex("#9400D3");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class HslTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void AliceBlueHslToMunsell() {
				var knownColor = new Hsl { H = 208, S = 100, L = 97, };
				var expectedColor = new Munsell("2PB 9.61/0.99");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void AliceBlueHslToHex() {
				var knownColor = new Hsl { H = 208, S = 100, L = 97, };
				var expectedColor = new Hex("f0f8ff");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class LabTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void RedLabToMunsell() {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Munsell("7.5R 5/20");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void RedLabToHex() {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Hex("ff0000");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class LchTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{
			[TestMethod]
			public void MaroonLchToMunsell() {
				var knownColor = new Lch { L = 24.829, C = 60.093, H = 38.180, };
				var expectedColor = new Munsell("10R 3/12");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void MaroonLchToHex() {
				var knownColor = new Lch { L = 24.829, C = 60.093, H = 38.180, };
				var expectedColor = new Hex("7d0000");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class XyzTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{

			[TestMethod]
			public void RivergumXyzToMunsell() {
				var knownColor = new Xyz { X = 13.123, Y = 15.372, Z = 13.174, };
				var expectedColor = new Munsell("7.5GY 4/2");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void RivergumXyzToHex() {
				var knownColor = new Xyz { X = 13.123, Y = 15.372, Z = 13.174, };
				var expectedColor = new Hex("62715F");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

		}
	}

	public class LuvTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{


			[TestMethod]
			public void SilverLuvToMunsell() {
				var knownColor = new Luv { L = 77.704, U = .001, V = -.013, };
				var expectedColor = new Munsell("N7.5");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void SilverLuvToHex() {
				var knownColor = new Luv { L = 77.704, U = .001, V = -.013, };
				var expectedColor = new Hex("c0c0c0");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class HsvTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{

			[TestMethod]
			public void AquamarineHsvToMunsell() {
				var knownColor = new Hsv { H = 160, S = .5, V = 1, };
				var expectedColor = new Munsell("7.5G 9/8");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void AquamarineHsvToHex() {
				var knownColor = new Hsv { H = 160, S = .5, V = 1, };
				var expectedColor = new Hex("80ffd4");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

		}
	}

	public class HsbTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{


			[TestMethod]
			public void AquamarineHsbToMunsell() {
				var knownColor = new Hsb { H = 160, S = .5, B = 1, };
				var expectedColor = new Munsell("7.5G 9/8");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
			[TestMethod]
			public void AquamarineHsbToHexl() {
				var knownColor = new Hsb { H = 160, S = .5, B = 1, };
				var expectedColor = new Hex("80FFD4");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}

	public class HunterLabTest
	{
		[TestClass]
		public class To : ColorSpaceTest
		{


			[TestMethod]
			public void SalmonHunterLabToMunsell() {
				var knownColor = new HunterLab { L = 60.809, A = 40.886, B = 22.664, };
				var expectedColor = new Munsell("7.5R 7/12");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}

			[TestMethod]
			public void SalmonHunterLabToHex() {
				var knownColor = new HunterLab { L = 60.809, A = 40.886, B = 22.664, };
				var expectedColor = new Hex("FA8072");

				ExpectedValuesForKnownColor(knownColor, expectedColor);
			}
		}
	}
}
