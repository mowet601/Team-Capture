﻿using UnityEngine;

namespace Team_Capture.Player.Movement
{
	//This code is built on unity-fastpacedmultiplayer
	//https://github.com/JoaoBorks/unity-fastpacedmultiplayer
	//
	//MIT License
	//Copyright (c) 2015 ultimatematchthree, 2017 Joao Borks [joao.borks@gmail.com]

	/// <summary>
	///     The inputs to send to the server
	/// </summary>
	public struct PlayerInputs
	{
		public PlayerInputs(Vector2 dirs, Vector2 mouseDirs, bool jump, int inputNum)
		{
			Directions = dirs;
			MouseDirections = mouseDirs;
			Jump = jump;
			InputNum = inputNum;
		}

		public Vector2 Directions;
		public Vector2 MouseDirections;

		public bool Jump;

		public int InputNum;

		public static PlayerInputs Zero =>
			new PlayerInputs(Vector2.zero, Vector2.zero, false, 0);
	}
}