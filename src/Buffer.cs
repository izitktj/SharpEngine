using System;
using System.Text;

namespace SharpEngine;

public static class Buffer
{
	public static char[,] buffer {get; private set;}
	public static int LimitX {get; private set;}
	public static int LimitY {get; private set;}

	/*
	Draws in console everything saved on buffer[,] array
	*/
	public static void drawBuffer()
	{
		Console.SetCursorPosition(0, 0);

								  //Part 1       -  Part 2
		byte[] _buffer = new byte[LimitX * LimitY + (LimitY /** 2*/)];

		//Convert 2D array navigation to a 1D array navigation
		int total = -1; //for start in 0 i put this -1

		for (int i = 0; i < LimitY; i++)
		{
		    for (int j = 0; j < LimitX; j++)
		    {
		    	//This uses part 1
		    	total++;
		    	_buffer[total] = Convert.ToByte(buffer[j, i]);
		    }

		    //This uses Part 2
		    total++;
		    _buffer[total] = Convert.ToByte('\n');
		}

		using (Stream stdout = Console.OpenStandardOutput(/*_buffer.Length*/))
		{
			//Prints all
		    stdout.Write(_buffer, 0, _buffer.Length);
		}
	}


	/*
	Clean-up the buffer[,] array
	*/
	public static void Clear()
	{
		Array.Clear(buffer);
	}


	/*
	Add a single char on buffer[,] array

	Ex:
	Buffer.updateChar('#', 5, 5);
	*/
	public static void updateChar(char _char, int _x, int _y)
	{
		buffer[_x, _y] = _char;
	}


	/*
	Add a text on buffer[,] array

	Ex:
	Buffer.updateText("I like bananas", 10, 5);
	*/
	public static void updateText(string _text, int _x = 0, int _y = 0)
	{
		for(int i = _x; i < _text.Length; i++)
		{
			updateChar(_text[i],i , _y);
		}
	}


	/*
	Draws a quad on buffer[,] array

	Ex:
	char[] beatyQuad = 
	{
		'0', '0', '0', '0',
    	'0', '0', '0', '0',
    	'0', '0', '0', '0',
    	'0', '0', '0', '0'
	};

	Buffer.updateQuad(beatyQuad, 5, 5, 9, 9);
	*/
	public static void updateQuad(char[] _quad, int _x, int _y, int _limitX, int _limitY)
	{
		int y = _y;
		int x = _x;

		for(int i = 0; i < _quad.Length; i++)
		{
			if(y == _limitY) return; //if reachs bounds, return.

			updateChar(_quad[i], x, y);

			if(x + 1 != _limitX)
			{
				x += 1; //next space
			}
			else
			{
				y += 1;
				x = _x;	//next line
			}
		}
	}

	public static void changeBufferLimit(int _limitX, int _limitY)
	{
		LimitX = _limitX;
		LimitY = _limitY;

		buffer = new char[_limitX, _limitY];

		Console.SetCursorPosition(0, 0);
	}

	public static void changeResolution()
	{
   		int Width = Console.WindowWidth - 1;
   		int Height = Console.WindowHeight - 1;

   		changeBufferLimit(Width, Height);

   		buffer = new char[Width, Height];

   		Console.SetCursorPosition(0, 0);
	}
}