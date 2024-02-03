using System;

namespace SharpEngine;
internal class Program
{
	static void Main(string[] args)
	{
		int Width = Console.WindowWidth;
		int Height = Console.WindowHeight;

	    //Pchar player = new Pchar('0');
	    Buffer bffr = new Buffer(Width, Height);
	    TimeEngine TimeE = new TimeEngine();



	    while(true)
	    {

	    	bffr.clear();

	    	//bffr.updateChar(player.Schar, player.X, player.Y);

	    	bffr.updateText("Delta time:", 0, 2);

	    	bffr.updateText(Convert.ToString(TimeE.deltaTime), 0, 3);

	    	bffr.drawBuffer();

	    	//player.position(player.X, player.Y + 1);

	    	//System.Threading.Thread.Sleep(500);

			if(Console.WindowWidth != Width || Console.WindowHeight != Height)
	    	{
	    		Width = Console.WindowWidth;
				Height = Console.WindowHeight;

	    		bffr.changeBufferLimit(Width, Height);
	    	}

	    	TimeE.calculeDeltaTime();
	    }
	}
}