using System;

namespace SharpEngine;

public class GameObject
{
	public double X {get; private set;}
	public double Y {get; private set;}
	public char Char {get; private set;}

	public GameObject(char _char, double _x = 0.0d, double _y = 0.0d)
	{
		X = _x;
		Y = _y;
		Char = _char;
	}

	public void position(double _x, double _y)
	{
		X = _x;
		Y = _y;
	}

	public void changeChar(char _char)
	{
		Char = _char;
	}
}