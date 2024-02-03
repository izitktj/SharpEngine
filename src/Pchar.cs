using System;

namespace SharpEngine;

public class Pchar
{
	public int X {get; private set;}
	public int Y {get; private set;}
	public char Schar {get; private set;}

	public Pchar(char _pChar, int _x = 0, int _y = 0)
	{
		X = _x;
		Y = _y;
		Schar = _pChar;
	}

	public void position(int _x, int _y)
	{
		X = _x;
		Y = _y;
	}

	public void changePchar(char _pChar)
	{
		Schar = _pChar;
	}
}