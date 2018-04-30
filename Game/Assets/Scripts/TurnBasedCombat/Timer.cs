using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	Image TimeBar;

	public float maxTime=5f;

	float TimeLeft;

	public GameObject timesUpText;

	// Use this for initialization
	void Start () {
		timesUpText.SetActive(false);
		TimeBar = GetComponent<Image>();
		TimeLeft = maxTime;
	}
	
	// Update is called once per frame
	void Update () {

		if (TimeLeft>0) {
			TimeLeft -= Time.deltaTime;
			TimeBar.fillAmount = TimeLeft/maxTime;
		}

		else {
			timesUpText.SetActive(true);

			GameObject AttackActionMenu = GameObject.Find("AttackAction");

			AttackActionMenu.SetActive(false);
		}
		
	}
}
