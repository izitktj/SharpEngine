using System;

namespace SharpEngine;

public class Time
{
	public double deltaTime {get; private set;}

	public double lastDeltaTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerMillisecond;

	public void calculeDeltaTime()
	{
		double currentTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerMillisecond;

		deltaTime = currentTime - lastDeltaTime;

		lastDeltaTime = currentTime;
	}
}