using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strokesCount : MonoBehaviour {

	public int strokesAmount;
	public float buttonSpeed;
	private Vector2 position = Vector2.zero;

	string strokeString;


	void Start () {
	buttonSpeed = 0.5f; //0.3 difficult 

	InvokeRepeating("MoveButton", 0f,buttonSpeed);
	}
	
	
	void Update () {
	
	
	}

	public void IncreaseStrokesAmount() {
		strokesAmount += 1;

		Text strokeText = GameObject.Find("strokeText").GetComponent<Text>();
		strokeString = strokesAmount.ToString(); 
		strokeText.text = strokeString + " Strokes";

	}

	void MoveButton () {

		RectTransform rt = GetComponent<RectTransform>();

		float rndm = Random.Range(-200,200);

		position.Set(rndm, 0);

		rt.anchoredPosition = position;

		Debug.Log("MoveButton On");
	}

}
