﻿using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using Logger = Core.Logging.Logger;

namespace Console
{
	/// <summary>
	/// An in-game console
	/// </summary>
	public class ConsoleGUI : MonoBehaviour, IConsoleUI
	{
		[SerializeField] private TMP_InputField inputField;
		[SerializeField] private TextMeshProUGUI consoleTextArea;
		[SerializeField] private GameObject consolePanel;
		[SerializeField] private KeyCode consoleToggleKey = KeyCode.F1;

		[SerializeField] private bool showDebugMessages;

		[SerializeField] private float consoleTextScale = 1;
		private float defaultFontSize;

		private readonly List<string> lines = new List<string>();

		public void Init()
		{
			defaultFontSize = consoleTextArea.fontSize;

			//Disable it
			ToggleConsole();

			Logger.Info("Console in-game GUI ready!");
		}

		public void Shutdown()
		{
		}

		public void UpdateConsole()
		{
			if (Input.GetKeyDown(consoleToggleKey))
			{
				ToggleConsole();
			}

			if(!consolePanel.activeSelf) return;

			if (Input.GetKeyDown(KeyCode.Tab))
			{
				inputField.text = ConsoleBackend.AutoComplete(inputField.text);
				inputField.caretPosition = inputField.text.Length;
			}

			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.PageUp))
			{
				inputField.text = ConsoleBackend.HistoryUp(inputField.text);
				inputField.caretPosition = inputField.text.Length;
			}

			if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.PageDown))
			{
				inputField.text = ConsoleBackend.HistoryDown();
				inputField.caretPosition = inputField.text.Length;
			}

			if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
				SubmitInput();
		}

		#region Console GUI

		/// <summary>
		/// Toggles the in-game viewable console
		/// </summary>
		public void ToggleConsole()
		{
			consolePanel.SetActive(!IsOpen());

			if(IsOpen())
				inputField.ActivateInputField();
		}

		public bool IsOpen()
		{
			return consolePanel.activeSelf;
		}

		#endregion

		#region Console Input

		public void SubmitInput()
		{
			HandleInput(inputField.text);

			inputField.text = "";
			inputField.ActivateInputField();
		}

		private static void HandleInput(string value)
		{
			Logger.Info($"cmd>: {value}");

			if(string.IsNullOrWhiteSpace(value)) return;

			ConsoleBackend.ExecuteCommand(value);
		}
		
		#endregion

		#region Console Commands

		[ConCommand("help", "Shows a list of all the commands")]
		public static void HelpCommand(string[] args)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\n");

			foreach (KeyValuePair<string, ConsoleCommand> command in ConsoleBackend.GetAllCommands())
			{
				sb.Append($"`{command.Key}` - {command.Value.CommandSummary}\n");
			}

			Logger.Info(sb.ToString());
		}

		[ConCommand("version", "Shows Team-Capture's current version")]
		public static void VersionCommand(string[] args)
		{
			Logger.Info($"You are running TC version {Application.version} using Unity {Application.unityVersion}");
		}

		[ConCommand("console", "Toggles the console", CommandRunPermission.Both, 0, 0, true)]
		public static void ToggleConsoleCommand(string[] args)
		{
			if (ConsoleSetup.ConsoleUI is ConsoleGUI gui)
			{
				gui.ToggleConsole();
			}
		}

		[ConCommand("console_scale", "Changes the console's text scale", CommandRunPermission.Both, 1, 1, true)]
		public static void ConsoleScaleCommand(string[] args)
		{
			if (float.TryParse(args[0], out float result))
			{
				if (!(ConsoleSetup.ConsoleUI is ConsoleGUI gui)) return;

				gui.consoleTextScale = result;
				gui.consoleTextArea.fontSize = gui.defaultFontSize * gui.consoleTextScale;

				return;
			}

			Logger.Error("The imputed argument isn't a number!");
		}

		#endregion

		public void LogMessage(string message, LogType logType)
		{
			if(consoleTextArea == null) return;

			if(logType == LogType.Assert && !showDebugMessages) return;

			switch (logType)
			{
				case LogType.Assert:
				case LogType.Log:
					lines.Add(message);
					break;
				case LogType.Exception:
				case LogType.Error:
					lines.Add($"<color=red>{message}</color>");
					break;
				case LogType.Warning:
					lines.Add($"<color=yellow>{message}</color>");
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
			}

			int count = Mathf.Min(100, lines.Count);
			int start = lines.Count - count;
			consoleTextArea.text = string.Join("\n", lines.GetRange(start, count).ToArray());
		}
	}
}