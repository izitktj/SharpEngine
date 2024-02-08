using System;

namespace SharpEngine;
internal class Program
{

    static void Main(string[] args)
	{
        Buffer.changeBufferLimit(Console.WindowWidth - 1, Console.WindowHeight - 1); //-1 is needed for prevent stuterings

        while (true) 
        {
            Draw();

            Buffer.drawBuffer();

            Buffer.Clear();

            Time.calculeDeltaTime();
        } 
    }

    static void Draw()
    {
        Buffer.updateText("Delta time:", 0, 1);

        Buffer.updateText(Convert.ToString(Time.deltaTime), 0, 2);
    }
}