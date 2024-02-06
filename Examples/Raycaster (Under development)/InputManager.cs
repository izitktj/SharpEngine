using System;

namespace SharpEngine;

public class InputManager
{
	public delegate void Input(ConsoleKeyInfo _key);

	public event Input KeyPressed;

	public void KeyManagment()
	{
		if(Console.KeyAvailable == true)
		{
			ConsoleKeyInfo input = Console.ReadKey(true);

			if(KeyPressed != null)
			{
				KeyPressed(input);
			}
		}
	}
}