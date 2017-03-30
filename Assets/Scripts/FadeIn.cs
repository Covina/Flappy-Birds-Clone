﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	private float fadeDuration = 3f;
	private Image fadePanel;

	private float tempAlpha;

	// Use this for initialization
	void Start () {

		fadePanel = GetComponent<Image>();
		tempAlpha = fadePanel.color.a;
	}
	
	// Update is called once per frame
	void Update ()
	{

		// go from 1 to 0 in fadeDuration seconds
		// get alpha channel

		// reduce alpha chanel

		if (tempAlpha > 0) {

			tempAlpha -= Time.deltaTime / fadeDuration;

			fadePanel.color = new Color (fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, tempAlpha);
		} else {
			// turn it off so we can click stuff
			gameObject.SetActive(false);

		}

	}
}
