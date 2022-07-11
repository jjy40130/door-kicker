// Copyright (c) Jaeyun Jung From TeamH4C. All rights reserved.

using System.Collections;
using UnityEngine;

namespace TeamH4C.JaeyunJung {
	public class SuccessManager : MonoBehaviour {
		private bool _easterActivate = false;
		private Rigidbody2D _rigidbody = null;

		private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

		private void Start() => StartCoroutine(EasterActivateCoroutine());

		private void Update() {
			if (!_easterActivate) return;
			
			transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
			_rigidbody.AddRelativeForce(Vector2.up * 15 * Time.deltaTime);
		}

		private IEnumerator EasterActivateCoroutine() {
			yield return new WaitForSeconds(15f);
			_easterActivate = true;
		}
	}
}
