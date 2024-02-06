using System;

namespace SharpEngine;

public class EventManager
{
	InputManager InputManager = new InputManager();
	Program Program = new Program();
	Player Player = new Player();

	public void SubscribeEvents()
	{
		InputManager.KeyPressed += Program.OnKeyPressed;
		InputManager.KeyPressed += Player.OnKeyPressed;
	}
}