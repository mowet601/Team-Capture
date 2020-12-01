﻿using Tweens;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels
{
	/// <summary>
	///     The base for a main menu panel
	/// </summary>
	internal class MainMenuPanelBase : MonoBehaviour
	{
		/// <summary>
		///     The cancel or close button
		/// </summary>
		public Button cancelButton;

		public TweenObject tweenObject;

		public virtual void OnEnable()
		{
			tweenObject.PlayEvent("PanelOpen");
		}
	}
}