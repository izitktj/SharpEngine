using System;
using System.Text;

namespace SharpEngine;

public class Buffer
{
	public char[,] buffer {get; private set;}
	public int LimitX {get; private set;}
	public int LimitY {get; private set;}

	public Buffer(int _limitX, int _limitY)
	{
		LimitX = _limitX;
		LimitY = _limitY;

		buffer = new char[_limitX, _limitY];
	}

	public void updateChar(char _char, int _x, int _y)
	{
		buffer[_x, _y] = _char;
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

		// using (Stream stdout = Console.OpenStandardOutput(cols * rows))
		// {
		//     stdout.Write(buffer, 0, buffer.Length);
		// } 
		//nao sei como usar por isso comentei, irei pesquisar dps

		Console.Write(screen.ToString());
	}

	public void clear()
	{
		// for (int i = 0; i < LimitY; i++)
		// {
		//     for (int j = 0; j < LimitX; j++)
		//     {
		//         buffer[j, i] = ' ';
		//     }
		// }
		Array.Clear(buffer);
	}

	public void updateText(string _text, int _x = 0, int _y = 0)
	{
		for(int i = 0; i < _text.Length; i++)
		{
			updateChar(_text[i], i += _x, _y);
		}
	}

	public void changeBufferLimit(int _limitX, int _limitY)
	{
		LimitX = _limitX;
		LimitY = _limitY;

		buffer = new char[_limitX, _limitY];

		Console.Clear();
	}
}