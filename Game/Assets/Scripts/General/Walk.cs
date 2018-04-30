using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk:MonoBehaviour {


	// Use this for initialization
	void Start () {
		
		Debug.Log ("Hi");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("left")) { 
			Flip ("left");
			transform.Translate(-0.2f, 0, 0); 
		}

		if (Input.GetKey("right")) { 
			Flip ("right");
			transform.Translate(0.2f, 0, 0); 
		}
	}

	public void Flip (string direction) {
		var thescale = transform.localScale; 
		if (direction == "left") {
			thescale.x= -1;
		}

		else {
			thescale.x= 1;
		}

		transform.localScale=thescale; 
	}
}
