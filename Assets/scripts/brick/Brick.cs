﻿using UnityEngine;

public class Brick : MonoBehaviour {

	private void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "ball") {
			Destroy(gameObject);
		}
	}
}
