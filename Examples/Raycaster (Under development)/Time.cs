using System;

namespace SharpEngine;

public static class Time
{
	public static double deltaTime {get; private set;}

	static double lastDeltaTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerMillisecond;

	public static void calculeDeltaTime()
	{
		double currentTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerMillisecond;

		deltaTime = currentTime - lastDeltaTime;

		lastDeltaTime = currentTime;
	}
}