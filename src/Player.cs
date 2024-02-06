using System;

namespace SharpEngine;

public class Player
{
	GameObject GOPlayer = new GameObject(' ');
	int Velocity = 1;

	public Player(GameObject _player = null, int _velocity = 1)
	{
		GOPlayer = _player;
		Velocity = _velocity;
	}

    // InputSide InputManagment()
    // {
    // 	ConsoleKeyInfo input = Console.ReadKey(true);

    // 	InputSide Out = new InputSide(0,0);

    // 	switch(input.Key)
    // 	{
    // 	  case ConsoleKey.W:
    // 	    Out.Vertical = -1;
    // 	    break;

    // 	  case ConsoleKey.S:
    // 	    Out.Vertical = 1;
    // 	    break;

    // 	  case ConsoleKey.D:
    // 	    Out.Horizontal = 1;
    // 	    break;

    // 	  case ConsoleKey.A:
    // 	    Out.Horizontal = -1;
    // 	    break;

    // 	  default:
    // 	    Out.Horizontal = 0;
    // 	    Out.Vertical = 0;
    // 	    break;
    // 	}

    // 	return Out;
    // } 

    public void MovementManager(InputSide Side)
    {
    	GOPlayer.position(GOPlayer.X, Convert.ToDouble(GOPlayer.Y + Side.Vertical * Velocity));

    	GOPlayer.position(Convert.ToDouble(GOPlayer.X + Side.Horizontal * Velocity) , GOPlayer.Y);
    }

    public void OnKeyPressed(ConsoleKeyInfo input)
    {
    	Thread.Sleep(5000);

    	InputSide Out = new InputSide(0,0);

    	switch(input.Key)
    	{
    	  case ConsoleKey.W:
    	    Out.Vertical = -1;
    	    break;

    	  case ConsoleKey.S:
    	    Out.Vertical = 1;
    	    break;

    	  case ConsoleKey.D:
    	    Out.Horizontal = 1;
    	    break;

    	  case ConsoleKey.A:
    	    Out.Horizontal = -1;
    	    break;

    	  default:
    	    Out.Horizontal = 0;
    	    Out.Vertical = 0;
    	    break;
    	}

    	MovementManager(Out);
    }
}


public struct InputSide
{
	public int Vertical = 0;
	public int Horizontal = 0;

	public InputSide(int _v = 0, int _h = 0)
	{
		Vertical = _v;
		Horizontal = _h;
	}
}