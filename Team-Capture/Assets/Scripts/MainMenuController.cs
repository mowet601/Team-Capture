﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Panels;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
	public Transform mainMenuPanel;

	public List<MainMenuPanels> menuPanels = new List<MainMenuPanels>();

	[Header("Black Background")]
	public Animator blackBackgroundAnimator;

	public string blackBackgroundCloseTriggerName = "Exit";

	public float blackBackgroundWaitTime = 0.2f;

	[Header("Top Black Bar")]
	public Animator topBlackBarAnimator;

	public string topBlackBarCloseTriggerName = "Exit";

	public float topBlackBarWaitTime = 0.2f;

	public void Start()
	{
		topBlackBarAnimator.gameObject.SetActive(false);

		//Pre create all panels
		foreach (MainMenuPanels menuPanel in menuPanels)
		{
			GameObject panel = Instantiate(menuPanel.panelPrefab, mainMenuPanel);
			panel.name = menuPanel.panelName;
			panel.SetActive(false);
			menuPanel.panelObject = panel;

			if(panel.GetComponent<QuitPanel>() != null)
				panel.GetComponent<QuitPanel>().noBtn.onClick.AddListener(delegate{TogglePanel(menuPanel.panelName);});
		}
	}

	public void TogglePanel(string panelName)
	{
		MainMenuPanels panel = GetMenuPanel(panelName);

		if (panel.isOpen)
		{
			Debug.Log($"Closing {panel.panelName}");

			if (panel.menuEvent.showTopBlackBar)
				StartCoroutine(DeactivateTopBlackBar());

			if (panel.menuEvent.darkenScreen)
				StartCoroutine(DeactivateBlackBackground());
				
			panel.panelObject.SetActive(false);
			panel.isOpen = false;

			return;
		}

		if (!panel.isOpen)
		{
			Debug.Log($"Opening {panel.panelName}");

			if(panel.menuEvent.showTopBlackBar)
				ActivateTopBlackBar();

			if (panel.menuEvent.darkenScreen)
				ActivateBlackBackground();

			panel.panelObject.SetActive(true);
			panel.isOpen = true;
		}
	}

	private MainMenuPanels GetMenuPanel(string panelName)
	{
		IEnumerable<MainMenuPanels> result = from a in menuPanels
			where a.panelName == panelName
			select a;

		return result.FirstOrDefault();
	}

	#region Animation Functions

	private void ActivateTopBlackBar()
	{
		topBlackBarAnimator.gameObject.SetActive(true);
	}

	private IEnumerator DeactivateTopBlackBar()
	{
		topBlackBarAnimator.SetTrigger(topBlackBarCloseTriggerName);
		yield return new WaitForSeconds(topBlackBarWaitTime);
		topBlackBarAnimator.gameObject.SetActive(false);
	}

	private void ActivateBlackBackground()
	{
		blackBackgroundAnimator.gameObject.SetActive(true);
	}

	private IEnumerator DeactivateBlackBackground()
	{
		blackBackgroundAnimator.SetTrigger(blackBackgroundCloseTriggerName);
		yield return new WaitForSeconds(blackBackgroundWaitTime);
		blackBackgroundAnimator.gameObject.SetActive(false);
	}

	#endregion

	[Serializable]
	public class MainMenuPanels
	{
		public string panelName;
		public TCMainMenuEvent menuEvent;
		public GameObject panelPrefab;

		[HideInInspector] public GameObject panelObject;

		[HideInInspector] public bool isOpen;
	}
}