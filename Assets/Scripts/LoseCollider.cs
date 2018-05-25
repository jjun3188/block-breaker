﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager LevelManager;
	
	private void OnTriggerEnter2D(Collider2D collision) {
		print("Trigger");
		LevelManager.LoadLevel("Win");
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		print("Collision");
	}
}
