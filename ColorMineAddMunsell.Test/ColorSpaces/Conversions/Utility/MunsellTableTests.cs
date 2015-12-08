using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.ColorSpaces.Conversions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColorMine.ColorSpaces;

namespace ColorMineAddMunsell.Test.ColorSpaces.Conversions.Utility.Tests
{
	[TestClass()]
	public class MunsellTableTests
	{
		[TestMethod()]
		public void MunsellTableTest() {
			//var t = new MunsellTable();

			//foreach (var m in t) {
			//	m.Lch = m.Yxy.To<Lch>();
			//}

			//t.SaveB();

			//Assert.Fail();
		}

		[TestMethod()]
		public void TmpTest() {
			var m = new Munsell("7.2Y 5.5/3");
			var rgb = m.To<Rgb>();
			var munsell = rgb.To<Munsell>();
		}

		[TestMethod()]
		public void TmpTest2() {
			var rgb = new Rgb {R=197,G=128,B=155 };
			var munsell = rgb.To<Munsell>();
		}

		[TestMethod()]
		public void TmpTest3() {
			var m = new Munsell("N9.25");
			var str = m.ToString();
		}

		[TestMethod()]
		public void TmpTest4() {
			var rgb = new Rgb { R = 200, G = 100, B = 100 };
			var hex = rgb.To<Hex>();
			hex.R = "F1";
		}
	}
}