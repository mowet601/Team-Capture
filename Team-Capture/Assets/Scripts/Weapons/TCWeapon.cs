﻿using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "New TC Weapon", menuName = "Team Capture/TCWeapon")]
    public class TCWeapon : ScriptableObject
    {
        public GameObject baseWeaponPrefab;

		public int damage;
		public int range;
		public int fireRate;

		public GameObject baseWeaponPrefab;

		public int maxBullets;

		public float reloadTime = 2.0f;

		[HideInInspector] public int currentBulletsAmount;
		[HideInInspector] public bool isReloading;

		public void Reload()
		{
			currentBulletsAmount = maxBullets;
		}
	}
}

