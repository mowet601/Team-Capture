﻿using System;
using System.IO;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Core
{
	public static class Game
	{
		/// <summary>
		/// Quits the game
		/// </summary>
		public static void QuitGame()
		{
			Logger.Logger.Log("Goodbye!");

#if UNITY_EDITOR
			EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
		}

		/// <summary>
		/// Gets the path where the game's exe is
		/// <para>(Or with the editor is is under the `/Game` folder)</para>
		/// </summary>
		/// <returns></returns>
		public static string GetGameExecutePath()
		{
#if UNITY_EDITOR
			return Directory.GetParent(Application.dataPath).FullName + "/Game";
#else
			return Directory.GetParent(Application.dataPath).FullName;
#endif
		}

		public static string GetGameConfigPath()
		{
			//Get our initial documents folder
			string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\";

			//And make sure the 'My Games' folder exists
			if (!Directory.Exists(documentsFolder))
				Directory.CreateDirectory(documentsFolder);

			//Add on our game name
			documentsFolder += Application.productName + @"\";

			//And make sure our game name folder exists as well
			if (!Directory.Exists(documentsFolder))
				Directory.CreateDirectory(documentsFolder);

			return documentsFolder;
		}
	}
}