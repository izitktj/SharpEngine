using System;

namespace SharpEngine;
internal class Program
{
    static void Main(string[] args)
	{
        int Width = Console.WindowWidth / 2;
        int Height = Console.WindowHeight / 2;

        Buffer bffr = new Buffer(Width, Height);
        TimeEngine TimeE = new TimeEngine();

        while (true) {
            bffr.clear();

            bffr.updateText("Delta time:", 0, 2);

            bffr.updateText(Convert.ToString(TimeE.deltaTime), 0, 3);

            bffr.drawBuffer();

            //if (Console.WindowWidth != Width || Console.WindowHeight != Height) {
            //    Width = Console.WindowWidth;
            //    Height = Console.WindowHeight;

            //    bffr.changeBufferLimit(Width, Height);
            //}

            TimeE.calculeDeltaTime();
        }
    }
}