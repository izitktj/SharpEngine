using System;

namespace SharpEngine;

public static class MathE
{
	public static double PI = 3.1415926535; //less precise than Math.PI() but is that we need

	public static int RoundToInt(double _num)
	{
		return Convert.ToInt32(Math.Round(_num));
	}
}