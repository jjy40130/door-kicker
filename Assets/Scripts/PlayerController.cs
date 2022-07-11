// Copyright (c) Jaeyun Jung From TeamH4C. All rights reserved.

using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace TeamH4C.JaeyunJung {
	public class PlayerController : MonoBehaviour {
		public static Action kickAction = null;
		
		[SerializeField, BoxGroup("Default")]
		private float _kickCooldown = 0f;
		
		private static bool _quitProgram = true;
		private Animator _animator = null;
		private float _currentKickCooldown = 0f;

		private void Awake() => _animator = GetComponent<Animator>();

		private void Update() {
			if (!Input.GetKeyDown(KeyCode.Space)) return;
			KickTheDoor();
		}

		private void KickTheDoor() {
			if (_currentKickCooldown > 0) return;
			
			if (_quitProgram) {
				Application.Quit();
				return;
			}
			
			_animator.SetTrigger("Kick");
			kickAction.Invoke();
			StartCoroutine(KickCooldownCoroutine());
		}

		private IEnumerator KickCooldownCoroutine() {
			_currentKickCooldown = _kickCooldown;
			while (_currentKickCooldown > 0) {
				_currentKickCooldown -= Time.deltaTime;
				yield return new FixedUpdate();
			}

			_currentKickCooldown = 0f;
			yield break;
		}
	}
}
