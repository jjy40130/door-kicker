// Copyright (c) Jaeyun Jung From TeamH4C. All rights reserved.

using DG.Tweening;
using UnityEngine;

namespace TeamH4C.JaeyunJung {
	public class House : MonoBehaviour {
		private const float CHANGE_SIZE = 0.1f;
		
		private bool _canKick = true;
		private AudioSource _audioSource = null;

		private void Awake() => _audioSource = GetComponent<AudioSource>();

		private void Start() => PlayerController.kickAction += OnKickTheDoor;

		private void OnKickTheDoor() {
			if (!_canKick) return;
			
			_canKick = false;
			transform.DOPunchScale(new Vector3(CHANGE_SIZE, CHANGE_SIZE, 0f), 0.5f).OnComplete(() => _canKick = true);
			_audioSource.Play();
		}
	}
}
