﻿using MessagePack;
using UnityEngine;

namespace Team_Capture.Core.Networking.MessagePack
{
	[MessagePackObject]
	public struct WeaponShootEffectsTargets
	{
		[Key(0)] public Vector3[] Targets { get; set; }

		[Key(1)] public Vector3[] TargetNormals { get; set; }
	}
}