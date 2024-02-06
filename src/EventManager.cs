using System;

namespace SharpEngine;

public class EventManager
{
	InputManager InputManager = new InputManager();

	public void SubscribeEvents(Player Player)
	{
		InputManager.KeyPressed += Player.OnKeyPressed;
	}
}