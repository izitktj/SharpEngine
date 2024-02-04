using System;

namespace SharpEngine;
internal class Program
{
    static void Main(string[] args)
	{
        Buffer bffr = new Buffer(Console.WindowWidth / 2, Console.WindowHeight / 2);
        Time Time = new Time();
        GameObject player = new GameObject('⬛', 10, 10);

        while (true) {

        	bffr.updateChar(player.Char, player.X, player.Y);

            bffr.updateText("Delta time:", 0, 2);

            bffr.updateText(Convert.ToString(Time.deltaTime), 0, 3);

            bffr.drawBuffer();

            bffr.clear();

            bffr.changeResolution();

            Time.calculeDeltaTime();
        }
    }
}