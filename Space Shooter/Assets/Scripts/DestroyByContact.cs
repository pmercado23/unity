﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameConroller gameController;

	void Start(){
	
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null) {

			gameController = gameControllerObject.GetComponent <GameConroller> ();
		}
		if (gameController == null) {
		
			Debug.Log ("Error: Cannot Find 'GameController' script.");
		}
	
	}



	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy")) {
			return;
		}

		if (explosion != null) {
			Instantiate (explosion, transform.position, transform.rotation);
		}
		if (other.CompareTag ("Player")) {
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}

		gameController.AddScore(scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
