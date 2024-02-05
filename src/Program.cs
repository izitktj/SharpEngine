using System;

namespace SharpEngine;
internal class Program
{

    static void Main(string[] args)
	{
        Buffer bffr = new Buffer(Console.WindowWidth - 1, Console.WindowHeight - 1);
        Time Time = new Time();
        GameObject player = new GameObject('#', 10, 10);
        Player Player = new Player();

        while (true) {

        	Player.MovementManager(player, 1, Time, bffr);

        	Draw(bffr, player, Time);

            bffr.drawBuffer();

            bffr.clear();

            bffr.changeResolution();

            Time.calculeDeltaTime();
        }
    }

    static void Draw(Buffer _bffr, GameObject _player, Time _time)
    {
    	char[] map =
    	{
    		'0', '0', '0', '0', '¨',
    		'0', '0', '0', '0', '¨', 
    		'1', '2', '0', '0', '¨', 
    		'0', '1', '2', '0'
    	};

    	_bffr.updateChar(_player.Char, Math.Clamp(_player.X, 0, _bffr.LimitX - 1), Math.Clamp(_player.Y, 0, _bffr.LimitY - 1));

        _bffr.updateText("Delta time:", 0, 2);

        _bffr.updateText(Convert.ToString(_time.deltaTime), 0, 3);

        _bffr.updateText("PX: " + Convert.ToString(_player.X), 0, 4);

        _bffr.updateText("PY: " + Convert.ToString(_player.Y), 0, 5);

        _bffr.updateText("BX: " + Convert.ToString(_bffr.LimitX), 0, 6);

        _bffr.updateText("BY: " + Convert.ToString(_bffr.LimitY), 0, 7);

        _bffr.updateQuad(map, 9, 9);

    }
}