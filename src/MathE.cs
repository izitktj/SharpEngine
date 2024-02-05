using System;

namespace SharpEngine;

public class MathE
{
	public const double PI = 3.1415926535; //less precise than Math.PI() but is that we need

	public int RoundToInt(double _num)
	{
		return Convert.ToInt32(Math.Round(_num));
	}
}