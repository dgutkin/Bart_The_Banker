﻿using UnityEngine;
using System.Collections;

public class TaxBlockBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Player loses life on collision
	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("Player")) {
			GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat (Constants.SOUND_VOLUME, Constants.DEFAULT_SOUND_VOLUME);

			AudioClip ding = GetComponent<AudioSource>().clip;
			AudioSource.PlayClipAtPoint(ding, transform.position);
			Destroy (gameObject);
			other.SendMessage ("HitTaxBlock", SendMessageOptions.DontRequireReceiver);

		}

	}
}
