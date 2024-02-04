using System;

namespace SharpEngine;
internal class Program
{
    static void Main(string[] args)
	{
        Buffer bffr = new Buffer(Console.WindowWidth / 2, Console.WindowHeight / 2);
        TimeEngine TimeE = new TimeEngine();

        while (true) {
            bffr.updateText("Delta time:", 0, 2);

            bffr.updateText(Convert.ToString(TimeE.deltaTime), 0, 3);

            bffr.drawBuffer();

            bffr.clear();

            bffr.changeResolution();

            TimeE.calculeDeltaTime();
        }
    }
}