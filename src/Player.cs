using System;

namespace SharpEngine;

public class Player
{
    InputSide InputManagment()
    {
    	ConsoleKeyInfo input = Console.ReadKey(true);

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

    	return Out;
    } 

    public void MovementManager(GameObject _player, int _velocity, Time _time, Buffer _bffr)
    {
    	if(Console.KeyAvailable == false) return;

    	InputSide Side = InputManagment();

    	_player.position(_player.X, Math.Clamp(Convert.ToDouble(_player.Y + Side.Vertical * _velocity), 0, _bffr.LimitY));

    	_player.position(Math.Clamp(Convert.ToDouble(_player.X + Side.Horizontal * _velocity), 0, _bffr.LimitX) , _player.Y);
    }

    public void OnKeyPressed(ConsoleKeyInfo _key)
    {
        System.Environment.Exit(1);
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