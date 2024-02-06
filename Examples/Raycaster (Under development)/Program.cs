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
        EventManager EventManager = new EventManager();
        InputManager InputManager = new InputManager();
        GameObject player = new GameObject('#', 16, 16);
        Player Player = new Player(player, 1);

        EventManager.SubscribeEvents(Player, InputManager);
        Buffer.changeBufferLimit(Console.WindowWidth - 1, Console.WindowHeight - 1);
        // Buffer.changeResolution();

        while (true)
        {
            InputManager.KeyManagment();

            Draw(player);

            Buffer.drawBuffer();

            Buffer.clear();

            //Buffer.changeResolution();
            //sorry, not working

            Time.calculeDeltaTime();
        } 
    }

    static void Draw(GameObject _player)
    {
        Raycaster ryc = new Raycaster(_player);

        Buffer.updateQuad(ryc.MapChar, 15, 15, 23, 23);

    	Buffer.updateChar(_player.Char, Math.Clamp(_player.X, 0, Buffer.LimitX - 1), Math.Clamp(_player.Y, 0, Buffer.LimitY - 1));

        Buffer.updateText("Delta time:", 0, 2);

        Buffer.updateText(Convert.ToString(Time.deltaTime), 0, 3);

        Buffer.updateText("PX: " + Convert.ToString(_player.X), 0, 4);

        Buffer.updateText("PY: " + Convert.ToString(_player.Y), 0, 5);

        Buffer.updateText("BX: " + Convert.ToString(Buffer.LimitX), 0, 6);

        Buffer.updateText("BY: " + Convert.ToString(Buffer.LimitY), 0, 7);
    }
}