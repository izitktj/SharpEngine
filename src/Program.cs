using System;

namespace SharpEngine;
internal class Program
{

    static void Main(string[] args)
	{
        Program Program = new Program();
        
        Program.MainLoop();
    }

    public void MainLoop()
    {
        Buffer bffr = new Buffer(Console.WindowWidth - 1, Console.WindowHeight - 1);
        Time Time = new Time();
        EventManager EventManager = new EventManager();
        InputManager InputManager = new InputManager();
        GameObject player = new GameObject('#', 16, 16);
        Player Player = new Player(player, 1);

        EventManager.SubscribeEvents(Player);

        while (true) {

            //Player.MovementManager();

            InputManager.KeyManagment();

            Draw(bffr, player, Time);

            bffr.drawBuffer();

            bffr.clear();

            //bffr.changeResolution();
            //sorry, not working

            Time.calculeDeltaTime();
        } 
    }

    static void Draw(Buffer _bffr, GameObject _player, Time _time)
    {
        Raycaster ryc = new Raycaster(_player);

        _bffr.updateQuad(ryc.MapChar, 15, 15, 23, 23);

    	_bffr.updateChar(_player.Char, Math.Clamp(_player.X, 0, _bffr.LimitX - 1), Math.Clamp(_player.Y, 0, _bffr.LimitY - 1));

        _bffr.updateText("Delta time:", 0, 2);

        _bffr.updateText(Convert.ToString(_time.deltaTime), 0, 3);

        _bffr.updateText("PX: " + Convert.ToString(_player.X), 0, 4);

        _bffr.updateText("PY: " + Convert.ToString(_player.Y), 0, 5);

        _bffr.updateText("BX: " + Convert.ToString(_bffr.LimitX), 0, 6);

        _bffr.updateText("BY: " + Convert.ToString(_bffr.LimitY), 0, 7);
    }
}