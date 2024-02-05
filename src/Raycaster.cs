using System;

namespace SharpEngine;

public class Raycaster
{
	public int MapX {get; private set;}
	public int MapY {get; private set;}
	public int MapS {get; private set;}

	public int[] Map {get; private set;} = 
	{
		1, 1, 1, 1, 1, 1, 1, 1,
		1, 0, 1, 0, 0, 0, 0, 1,
		1, 0, 0, 0, 0, 0, 0, 1,
		1, 0, 0, 0, 0, 1, 1, 1,
		1, 0, 0, 0, 0, 0, 0, 1,
		1, 0, 1, 0, 0, 1, 0, 1,
		1, 0, 0, 0, 0, 0, 0, 1,
		1, 1, 1, 1, 1, 1, 1, 1
	};

	Raycaster()
	{
		MapX = 8;
		MapY = 8;
		MapS = 64;
	}
}