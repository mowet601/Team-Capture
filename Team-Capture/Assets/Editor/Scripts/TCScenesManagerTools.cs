﻿using Team_Capture.SceneManagement;
using UnityEditor;
using UnityEngine;

namespace Editor.Scripts
{
    public static class TCScenesManagerTools
    {
        [MenuItem("Team Capture/List All Scenes")]
        private static void ListAllTCScenes()
        {
            Debug.Log($"{nameof(TCScene)}s found:");
            foreach (TCScene tcScene in TCScenesManager.GetAllTCScenesInfo())
                Debug.Log($"{tcScene.scene} ({tcScene.DisplayNameLocalized})");
        }

        [MenuItem("Team Capture/List Enabled Scenes")]
        private static void ListAllEnabledScenes()
        {
            Debug.Log($"Enabled {nameof(TCScene)}s found:");
            foreach (TCScene tcScene in TCScenesManager.GetAllEnabledTCScenesInfo())
                Debug.Log($"{tcScene.scene} ({tcScene.DisplayNameLocalized})");
        }
    }
}