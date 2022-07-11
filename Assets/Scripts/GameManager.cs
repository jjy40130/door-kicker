// Copyright (c) Jaeyun Jung From TeamH4C. All rights reserved.

using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TeamH4C.JaeyunJung {
	public class GameManager : MonoBehaviour {
		private const string FLAG_FILE_NAME = "flag";
		
		private void Start() {
			PlayerController.kickAction += OnKickTheDoor;
			
			if (!System.Diagnostics.Debugger.IsAttached) return;
			Application.Quit();
		}

		private void OnKickTheDoor() {
			if (!File.Exists($"{Application.streamingAssetsPath}/{FLAG_FILE_NAME}")) return;
			string flag = File.ReadAllText($"{Application.streamingAssetsPath}/{FLAG_FILE_NAME}");

			// TODO
			if (flag.Equals("FLAG")) SceneManager.LoadScene("Success");
		}
	}
}
