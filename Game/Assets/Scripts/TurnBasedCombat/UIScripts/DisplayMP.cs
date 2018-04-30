using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMP : MonoBehaviour {

	private BasePlayer BasePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BasePlayer = GameObject.Find("player").GetComponent<BasePlayer>();
		
		Text mpnumber = GetComponent<Text>();
		string playerMPString = BasePlayer.MP.ToString();
		mpnumber.text = playerMPString;}
}
