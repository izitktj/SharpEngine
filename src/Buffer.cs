using System;
using System.Text;

namespace SharpEngine;

public class Buffer
{
	public char[,] buffer {get; private set;}
	public int LimitX {get; private set;}
	public int LimitY {get; private set;}

	MathE MathE = new MathE();

	public Buffer(int _limitX, int _limitY)
	{
		LimitX = _limitX;
		LimitY = _limitY;

		buffer = new char[_limitX, _limitY];
	}

	public void updateChar(char _char, double _x, double _y)
	{
		buffer[MathE.RoundToInt(_x), MathE.RoundToInt(_y)] = _char;
	}

	public void drawBuffer()
	{
		Console.SetCursorPosition(0, 0);

		StringBuilder screen = new StringBuilder("");

		for (int i = 0; i < LimitY; i++)
		{
		    for (int j = 0; j < LimitX; j++)
		    {
		    	screen.Append(buffer[j, i]);
		    }

		    screen.Append("\n");
		}

		var _buffer = Encoding.UTF8.GetBytes(screen.ToString());

		using (Stream stdout = Console.OpenStandardOutput())
		{
		    stdout.Write(_buffer, 0, _buffer.Length);
		}
	}

	public void clear()
	{
		Array.Clear(buffer);
	}

	public void updateText(string _text, int _x = 0, int _y = 0)
	{
		for(int i = 0; i < _text.Length; i++)
		{
			updateChar(_text[i], i += _x, _y);
		}
	}

	public void updateQuad(char[] _quad, int _x, int _y, int _limitX, int _limitY)
	{
		int y = _y;
		int x = _x;

		for(int i = 0; i < _quad.Length; i++)
		{
			updateChar(_quad[i], x, y);

			if(x + 1 != _limitX)
			{
				x += 1;
			}
			else
			{
				y += 1;
				x = _x;
			}
		}
	}

	public void changeBufferLimit(int _limitX, int _limitY)
	{
		LimitX = _limitX;
		LimitY = _limitY;

		buffer = new char[_limitX, _limitY];

		Console.SetCursorPosition(0, 0);
	}

	public void changeResolution()
	{
		int Width = Console.WindowWidth - 1;
		int Height = Console.WindowHeight - 1;

		if (Console.WindowWidth - 1 == Width || Console.WindowHeight - 1 == Height) return;

   		Width = Console.WindowWidth - 1;
   		Height = Console.WindowHeight - 1;

   		changeBufferLimit(Width, Height);

   		updateText("Changed reso", 3, LimitY - 10);
	}
}