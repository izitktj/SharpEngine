using System;

namespace SharpEngine;

public class GameObject
{
	public int X {get; private set;}
	public int Y {get; private set;}
	public char Char {get; private set;}

	public GameObject(char _char, int _x = 0, int _y = 0)
	{
		X = _x;
		Y = _y;
		Char = _char;
	}

	public void position(int _x, int _y)
	{
		X = _x;
		Y = _y;
	}

	public void changeChar(char _char)
	{
		Char = _char;
	}
}