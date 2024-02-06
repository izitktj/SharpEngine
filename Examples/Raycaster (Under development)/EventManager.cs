using System;

namespace SharpEngine;

public class EventManager
{
	public void SubscribeEvents(Player Player, InputManager InputManager)
	{
		InputManager.KeyPressed += Player.OnKeyPressed;
	}
}