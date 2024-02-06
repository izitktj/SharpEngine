using System;

namespace SharpEngine;

public class Raycaster
{
	public int MapX {get; private set;}
	public int MapY {get; private set;}
	public int MapS {get; private set;}

	public float playerDeltaX = 0.0f;
	public float playerDeltaY = 0.0f;
	public float playerAngle = 0.0f;

	GameObject Player = new GameObject(' ');

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

	public char[] MapChar {get; private set;} = 
	{
		'0', '0', '0', '0', '0', '0', '0', '0',
		'0', ' ', '0', ' ', ' ', ' ', ' ', '0',
		'0', ' ', ' ', ' ', ' ', ' ', ' ', '0',
		'0', ' ', ' ', ' ', ' ', '0', '0', '0',
		'0', ' ', ' ', ' ', ' ', ' ', ' ', '0',
		'0', ' ', '0', ' ', ' ', '0', ' ', '0',
		'0', ' ', ' ', ' ', ' ', ' ', ' ', '0',
		'0', '0', '0', '0', '0', '0', '0', '0'
	};

	public Raycaster(GameObject _player)
	{
		MapX = 8;
		MapY = 8;
		MapS = 64;

		Player = _player;
	}
}