using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHP : MonoBehaviour {

private BasePlayer BasePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BasePlayer = GameObject.Find("player").GetComponent<BasePlayer>();
		
		Text hpnumber = GetComponent<Text>();
		string playerHPString = BasePlayer.HP.ToString();
		hpnumber.text = playerHPString;

	}
}
