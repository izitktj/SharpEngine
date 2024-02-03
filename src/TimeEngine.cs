using System;
using System.Diagnostics;
using System.Threading;

namespace SharpEngine;

public class TimeEngine
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