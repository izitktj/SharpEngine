using System;

namespace SharpEngine;
internal class Program
{

    static void Main(string[] args)
	{
        Buffer Buffer = new Buffer(Console.WindowWidth - 1, Console.WindowHeight - 1);

        while (true) 
        {
            Draw(Buffer);

            Buffer.drawBuffer();

            Buffer.clear();

            Time.calculeDeltaTime();
        } 
    }

    static void Draw(Buffer _bffr)
    {
        _bffr.updateText("Delta time:", 0, 1);

        _bffr.updateText(Convert.ToString(Time.deltaTime), 0, 2);
    }
}