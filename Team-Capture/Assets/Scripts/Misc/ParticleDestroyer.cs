﻿using UnityEngine;

namespace Team_Capture.Misc
{
	/// <summary>
	///     Destroys a particle after <see cref="destroyDelayTime" /> passes
	/// </summary>
	public class ParticleDestroyer : MonoBehaviour
	{
		/// <summary>
		///     What delay to use until destroy
		/// </summary>
		[SerializeField] private float destroyDelayTime = 2.0f;

		private void Start()
		{
			Destroy(gameObject, destroyDelayTime);
		}
	}
}