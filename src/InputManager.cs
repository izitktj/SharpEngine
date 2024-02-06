using System;

namespace SharpEngine;

public class InputManager
{
	public delegate void Input(ConsoleKeyInfo _key);

	public event Input KeyPressed;

	public void KeyManagment()
	{
		while(true)
    	{
    		if(Console.KeyAvailable == false)
    		{
    			ConsoleKeyInfo input = Console.ReadKey(true);

				if(KeyPressed != null)
				{
					KeyPressed(input);
				}
    		}
    	}

		// Task.Factory.StartNew(
        //     () => {
        //     	while(true)
        //     	{
        //     		if(Console.KeyAvailable == false) return;
		// 			ConsoleKeyInfo input = Console.ReadKey(true);

		// 			if(KeyPressed != null)
		// 			{
		// 				KeyPressed(input);
		// 			}
        //     	}
        //     });
	}
}