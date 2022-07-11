// Copyright (c) Jaeyun Jung From TeamH4C. All rights reserved.

using System.Collections;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace TeamH4C.JaeyunJung {
	public class Text : MonoBehaviour {
		[SerializeField, BoxGroup("Default")]
		private float _animTime = 0f;
		[SerializeField, BoxGroup("Default")]
		private Color _animColor = Color.clear;

		private TMP_Text _text = null;

		private void Awake() => _text = GetComponent<TMP_Text>();

		private void Start() => StartCoroutine(TextCoroutine(_text.color));

		private IEnumerator TextCoroutine(Color originColor) {
			_text.DOColor(_animColor, _animTime).SetEase(Ease.Flash);
			yield return new WaitForSeconds(_animTime);
			_text.DOColor(originColor, _animTime).SetEase(Ease.Flash);
			yield return new WaitForSeconds(_animTime);
			StartCoroutine(TextCoroutine(originColor));
		}
	}
}
